Shader "My/Cube_Texture"
{
    Properties
    {
        _MainTex1 ("Albedo (RGB)", 2D) = "white" {}
        _MainTex2 ("Albedo (RGB)", 2D) = "white" {} // 텍스쳐 2개 받기
        //_LerpRange("Lerp Range", Range(0, 1)) = 0
    }
    SubShader
    {
        Tags { "RenderType"="Opaque" }

        CGPROGRAM
        #pragma surface surf Standard fullforwardshadows

        sampler2D _MainTex1;
        sampler2D _MainTex2;
        //float _LerpRange;

        struct Input
        {
            float2 uv_MainTex1;
            float2 uv_MainTex2;
        };

        void surf (Input IN, inout SurfaceOutputStandard o)
        {
            fixed4 c = tex2D (_MainTex1, IN.uv_MainTex1);
            fixed4 d = tex2D (_MainTex2, IN.uv_MainTex2);
            //o.Albedo = c.rgb;
            //o.Albedo = lerp(c.rgb, d.rgb, _LerpRange); // lerp 함수: 두 값을 섞어줌
            o.Albedo = lerp(c.rgb, d.rgb, d.a);
            //o.Albedo = lerp(d.rgb, c.rgb, d.a); // d,c 순서 바꾸면 보이는 게 반대로 
            o.Alpha = c.a;
        }
        ENDCG
    }
    FallBack "Diffuse"
}

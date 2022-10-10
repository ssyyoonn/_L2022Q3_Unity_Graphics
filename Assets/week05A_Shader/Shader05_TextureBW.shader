Shader "My/SurfaceShader/TextureBW"
{
    Properties
    {
        _MainTex ("Albedo (RGB)", 2D) = "white" {}
    }
    SubShader
    {
        Tags { "RenderType"="Opaque" }

        CGPROGRAM
        // #pragma surface surf Standard fullforwardshadows // <-- fullforwardshadows 삭제
        #pragma surface surf Standard 

        sampler2D _MainTex;

        struct Input
        {
            float2 uv_MainTex;
        };

        void surf (Input IN, inout SurfaceOutputStandard o)
        {
            fixed4 c = tex2D (_MainTex, IN.uv_MainTex);
            //o.Albedo = c.rgb;
            o.Albedo = (c.r + c.g + c.b)/3; // rgb값 합한 평균값 => float 값 하나로 전달 => 흑백
            o.Alpha = c.a;
        }
        ENDCG
    }
    FallBack "Diffuse"
}

Shader "My/Quad"
{
    Properties
    {
        _MainTex1 ("Albedo (RGB)", 2D) = "white" {}
        _MainTex2 ("Albedo (RGB)", 2D) = "white" {}
    }
    SubShader
    {
        Tags { "RenderType" = "Transparent" "Queue" = "Transparent" } // 투명..어쩌구

        CGPROGRAM
        #pragma surface surf Standard fullforwardshadows alpha:fade //fade 옵션 => 투명하게??-0- 

        sampler2D _MainTex1;
        sampler2D _MainTex2;

        struct Input
        {
            float2 uv_MainTex1; // vertex에 있는 uv 데이터
            float2 uv_MainTex2;
        };

        void surf (Input IN, inout SurfaceOutputStandard o)
        {
            fixed4 c = tex2D(_MainTex1, IN.uv_MainTex1);
            fixed4 d = tex2D(_MainTex2, float2(IN.uv_MainTex2.x, +IN.uv_MainTex2.y - _Time.y)); // x값은 고정 (좌우 이동 x)
            o.Emission = c.rgb * d.rgb; // 두 값을 곱해줌
            o.Alpha = c.a;
        }
        ENDCG
    }
    FallBack "Diffuse"
}

Shader "My/Standard//MyShader_Bump"
{
    Properties
    {
        _MainTex("Albedo (RGB)", 2D) = "white" {}
        _Glossiness("Smoothness", Range(0,1)) = 0.5
        _Metallic("Metallic", Range(0,1)) = 0.0
        _BumpMap("NormalMap", 2D) = "bump" {} // 특별히 지정된 거 없으면 표면 요철값??
    }
        SubShader
        {
            Tags { "RenderType" = "Opaque" }

            CGPROGRAM

            #pragma surface surf Standard fullforwardshadows

            sampler2D _MainTex;
            sampler2D _BumpMap;

            struct Input
            {
                float2 uv_MainTex;
                float2 uv_BumpMap;
            };

            half _Glossiness;
            half _Metallic;

            void surf(Input IN, inout SurfaceOutputStandard o)
            {
                fixed4 c = tex2D(_MainTex, IN.uv_MainTex);
                o.Albedo = c.rgb;
                o.Metallic = _Metallic;
                o.Smoothness = _Glossiness;
                
                fixed3 n = UnpackNormal(tex2D(_BumpMap, IN.uv_BumpMap)); // 2D 텍스쳐를 요철값으로 활용하기 위해...
                o.Normal = n; // Normal 변수 할당

                o.Alpha = c.a;
            }
            ENDCG
        }
            FallBack "Diffuse"
}

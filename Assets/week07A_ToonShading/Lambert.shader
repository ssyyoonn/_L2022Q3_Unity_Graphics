Shader "My/Lambert/Starter2"
{
    Properties
    {
        _MainTex ("Albedo (RGB)", 2D) = "white" {}
    }
    SubShader
    {
        Tags { "RenderType"="Opaque" }

        CGPROGRAM

        #pragma surface surf MyFunction noambient // 커스텀 함수

        sampler2D _MainTex;

        struct Input
        {
            float2 uv_MainTex;
        };

        void surf (Input IN, inout SurfaceOutput o) // 기존: void surf (Input IN, inout SurfaceOutputStandard o)
        {
            fixed4 c = tex2D (_MainTex, IN.uv_MainTex);
            o.Albedo = c.rgb;
            o.Alpha = c.a;
        }

        // 사용자 함수 정의 (사용자 함수 이름 앞에 Lighting이라는 키워드를 적어야 유니티가 인식)
        float4 LightingMyFunction(SurfaceOutput s, float3 lightDir, float atten) { // lightDir: 빛의 방향값(x,y,z)
                                                                                   // atten: 빛이 감쇄되는 정도(빛이 주변으로 갈때 점점 약해지는 것 표현
            // float result = dot(s.Normal, lightDir) * 0.5 + 0.5; // half-lamber 방식. 일반적으로 많이 사용됨
            
            float result = saturate(dot(s.Normal, lightDir));

            float4 final;
            final.rgb = s.Albedo * result;
            final.a = s.Alpha;

            return final;
        }

        ENDCG
    }
    FallBack "Diffuse"
}

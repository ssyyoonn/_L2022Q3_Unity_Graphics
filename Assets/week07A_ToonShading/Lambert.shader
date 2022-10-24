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

        #pragma surface surf MyFunction noambient // Ŀ���� �Լ�

        sampler2D _MainTex;

        struct Input
        {
            float2 uv_MainTex;
        };

        void surf (Input IN, inout SurfaceOutput o) // ����: void surf (Input IN, inout SurfaceOutputStandard o)
        {
            fixed4 c = tex2D (_MainTex, IN.uv_MainTex);
            o.Albedo = c.rgb;
            o.Alpha = c.a;
        }

        // ����� �Լ� ���� (����� �Լ� �̸� �տ� Lighting�̶�� Ű���带 ����� ����Ƽ�� �ν�)
        float4 LightingMyFunction(SurfaceOutput s, float3 lightDir, float atten) { // lightDir: ���� ���Ⱚ(x,y,z)
                                                                                   // atten: ���� ����Ǵ� ����(���� �ֺ����� ���� ���� �������� �� ǥ��
            // float result = dot(s.Normal, lightDir) * 0.5 + 0.5; // half-lamber ���. �Ϲ������� ���� ����
            
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
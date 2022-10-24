Shader "My/Lambert/2Pass"
{
    Properties
    {
        _MainTex ("Albedo (RGB)", 2D) = "white" {}
    }
    SubShader
    {
        Tags { "RenderType"="Opaque" }

        // CGPROGRAM~ENDCG ���� 1pass
        cull front // ������ �����?? ��... �ո��� ���������� ����
        CGPROGRAM
        #pragma surface surf NoLight vertex:vert noambient noshadow

        sampler2D _MainTex;

        struct Input
        {
            float2 uv_MainTex;
        };

        // vertex���� ������ �ִ� ������ �ִµ�, �� �������� ���ݾ� �� ũ�� �׸�
        void vert(inout appdata_full v) {
            v.vertex.xyz += v.normal.xyz * 0.003; // �� vertex�� ���� �������� �̵���Ŵ(�� ���, ������Ʈ ��ǯ)
        }

        void surf (Input IN, inout SurfaceOutput o)
        {
            fixed4 c = tex2D (_MainTex, IN.uv_MainTex);
            o.Albedo = c.rgb;
            o.Alpha = c.a;
        }

        float4 LightingNoLight(SurfaceOutput s, float3 lightDir, float atten) {
            return float4(0, 0, 0, 1); // ������ => �ܰ���
        }

        ENDCG
        // CGPROGRAM~ENDCG ���� 1pass

        // 2pass
        cull back // �޸��� ������ �ʰ� (�⺻ ����. �տ��� �� cull front�� ������� �ǵ���. �ո� ������)
        CGPROGRAM
        #pragma surface surf Lambert

        sampler2D _MainTex;

        struct Input
        {
            float2 uv_MainTex;
        };

        void surf(Input IN, inout SurfaceOutput o)
        {
            fixed4 c = tex2D(_MainTex, IN.uv_MainTex);
            o.Albedo = c.rgb;
            o.Alpha = c.a;
        }
        ENDCG
        // 2pass

    }
    FallBack "Diffuse"
}

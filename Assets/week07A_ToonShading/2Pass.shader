Shader "My/Lambert/2Pass"
{
    Properties
    {
        _MainTex ("Albedo (RGB)", 2D) = "white" {}
    }
    SubShader
    {
        Tags { "RenderType"="Opaque" }

        // CGPROGRAM~ENDCG 까지 1pass
        cull front // 정면을 숨기는?? 즉... 앞면을 렌더링하지 않음
        CGPROGRAM
        #pragma surface surf NoLight vertex:vert noambient noshadow

        sampler2D _MainTex;

        struct Input
        {
            float2 uv_MainTex;
        };

        // vertex마다 가지고 있는 방향이 있는데, 그 방향으로 조금씩 더 크게 그림
        void vert(inout appdata_full v) {
            v.vertex.xyz += v.normal.xyz * 0.003; // 각 vertex의 정면 방향으로 이동시킴(그 결과, 오브젝트 부풂)
        }

        void surf (Input IN, inout SurfaceOutput o)
        {
            fixed4 c = tex2D (_MainTex, IN.uv_MainTex);
            o.Albedo = c.rgb;
            o.Alpha = c.a;
        }

        float4 LightingNoLight(SurfaceOutput s, float3 lightDir, float atten) {
            return float4(0, 0, 0, 1); // 검은색 => 외곽선
        }

        ENDCG
        // CGPROGRAM~ENDCG 까지 1pass

        // 2pass
        cull back // 뒷면을 보이지 않게 (기본 세팅. 앞에서 쓴 cull front를 원래대로 되돌림. 앞면 렌더링)
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

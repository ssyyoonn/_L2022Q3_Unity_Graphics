Shader "My/SurfaceShader/Cube"
{
    Properties
    {
        _Color ("Color", Color) = (1,1,1,1)
        _MainTex ("Albedo (RGB)", 2D) = "white" {}
        _Red ("Red", Range(0, 1)) = 0
        _Green ("Green", Range(0, 1)) = 0
        _Blue ("Blue", Range(0, 1)) = 0
    }
    SubShader
    {
        Tags { "RenderType"="Opaque" }

        CGPROGRAM
        #pragma surface surf Standard fullforwardshadows

        sampler2D _MainTex;

        struct Input
        {
            float2 uv_MainTex;
        };

        fixed4 _Color; // 변수를 왜 다시 써줘야 하는가? : 게임 엔진이 제공하는 문법과 그래픽카드 회사에서 제공하는 표현이 섞여있기 때문에
                       // CGPROGRAM ~ ENDCG 사이에 있는 코드는 그래픽카드 회사에서 사용하는 문법
        float _Red;
        float _Green;
        float _Blue;

        void surf (Input IN, inout SurfaceOutputStandard o)
        {
            fixed4 c = tex2D (_MainTex, IN.uv_MainTex) * _Color;
            // o.Albedo = c.rgb; : rgb 값을 취한다
            o.Albedo = float3(_Red, _Green, _Blue); // Albedo 값은 float 3개 값으로 한다.
            o.Alpha = c.a;
        }
        ENDCG
    }
    FallBack "Diffuse"
}

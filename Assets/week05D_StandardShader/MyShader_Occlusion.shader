Shader "My/Standard/MyShader_Occlusion"
{
    Properties
    {
        _MainTex("Albedo (RGB)", 2D) = "white" {}
        _Glossiness("Smoothness", Range(0,1)) = 0.5
        _Metallic("Metallic", Range(0,1)) = 0.0
        _BumpMap("NormalMap", 2D) = "bump" {} // 특별히 지정된 거 없으면 표면 요철값??
        _Occlusion("Occlusion", 2D) = "white" {} // 특별히 지정된 거 없으면 white로
    }
        SubShader
    {
        Tags { "RenderType" = "Opaque" }

        CGPROGRAM

        #pragma surface surf Standard fullforwardshadows

        sampler2D _MainTex;
        sampler2D _BumpMap;
        sampler2D _Occlusion;

        struct Input
        {
            float2 uv_MainTex;
            float2 uv_BumpMap;
            //float2 uv_Occlusion; // occlusion 좌표값 쓰는 방법은 2가지가 있다. <== 따라서 Occlusion 좌표값 따로 두지 않을 것 
                                   // 1) bump 준 곳을 더 어둡게 하고싶으면 BumpMap 좌표값 끌어다쓰기
                                   // 2) 기존 MainTex를 어쩌구... MainTex 좌표값 끌어다쓰기. 
                                 
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

            o.Occlusion = tex2D(_Occlusion, IN.uv_MainTex); // MainTex의 좌표값 사용


            o.Alpha = c.a;
        }
        ENDCG
    }
        FallBack "Diffuse"
}

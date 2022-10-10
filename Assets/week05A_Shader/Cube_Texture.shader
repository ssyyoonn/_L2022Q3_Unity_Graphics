Shader "My/Cube_Texture"
{
    Properties
    {
        _MainTex1 ("Albedo (RGB)", 2D) = "white" {}
        _MainTex2 ("Albedo (RGB)", 2D) = "white" {} // �ؽ��� 2�� �ޱ�
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
            //o.Albedo = lerp(c.rgb, d.rgb, _LerpRange); // lerp �Լ�: �� ���� ������
            o.Albedo = lerp(c.rgb, d.rgb, d.a);
            //o.Albedo = lerp(d.rgb, c.rgb, d.a); // d,c ���� �ٲٸ� ���̴� �� �ݴ�� 
            o.Alpha = c.a;
        }
        ENDCG
    }
    FallBack "Diffuse"
}

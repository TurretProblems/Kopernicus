// Material wrapper generated by shader translator tool
using System;
using System.Reflection;
using UnityEngine;

using Kopernicus.MaterialWrapper;

namespace Kopernicus
{
    namespace Configuration
    {
        public class ScaledPlanetRimAerialLoader : ScaledPlanetRimAerial
        {
            // Main Color, default = (1,1,1,1)
            [ParserTarget("color")]
            public ColorParser colorSetter
            {
                get { return color; }
                set { color = value; }
            }

            // Specular Color, default = (0.5,0.5,0.5,1)
            [ParserTarget("specColor")]
            public ColorParser specColorSetter
            {
                get { return specColor; }
                set { specColor = value; }
            }

            // Shininess, default = 0.078125
            [ParserTarget("shininess")]
            public NumericParser<float> shininessSetter
            {
                get { return shininess; }
                set { shininess = value; }
            }

            [ParserTarget("texture")]
            public Texture2DParser textureSetter
            {
                get { return mainTex; }
                set { mainTex = value; }
            }

            // Base (RGB) Gloss (A), default = "white" { }
            [ParserTarget("mainTex")]
            public Texture2DParser mainTexSetter
            {
                get { return mainTex; }
                set { mainTex = value; }
            }

            [ParserTarget("mainTexScale")]
            private Vector2Parser mainTexScaleSetter
            {
                get { return mainTexScale; }
                set { mainTexScale = value; }
            }

            [ParserTarget("mainTexOffset")]
            private Vector2Parser mainTexOffsetSetter
            {
                get { return mainTexOffset; }
                set { mainTexOffset = value; }
            }
                       
            [ParserTarget("normals")]
            public Texture2DParser normalsSetter
            {
                get { return bumpMap; }
                set { bumpMap = value; }
            }

            // Normalmap, default = "bump" { }
            [ParserTarget("bumpMap")]
            public Texture2DParser bumpMapSetter
            {
                get { return bumpMap; }
                set { bumpMap = value; }
            }

            [ParserTarget("bumpMapScale")]
            private Vector2Parser bumpMapScaleSetter
            {
                get { return bumpMapScale; }
                set { bumpMapScale = value; }
            }

            [ParserTarget("bumpMapOffset")]
            private Vector2Parser bumpMapOffsetSetter
            {
                get { return bumpMapOffset; }
                set { bumpMapOffset = value; }
            }

            // Opacity, default = 1
            [ParserTarget("opacity")]
            public NumericParser<float> opacitySetter
            {
                get { return opacity; }
                set { opacity = value; }
            }

            // Rim Power, default = 3
            [ParserTarget("rimPower")]
            public NumericParser<float> rimPowerSetter
            {
                get { return rimPower; }
                set { rimPower = value; }
            }

            // Rim Blend, default = 1
            [ParserTarget("rimBlend")]
            public NumericParser<float> rimBlendSetter
            {
                get { return rimBlend; }
                set { rimBlend = value; }
            }

            // RimColorRamp, default = "white" { }
            [ParserTarget("rimColorRamp")]
            public Texture2DParser rimColorRampSetter
            {
                get { return rimColorRamp; }
                set { rimColorRamp = value; }
            }

            [ParserTarget("rimColorRampScale")]
            private Vector2Parser rimColorRampScaleSetter
            {
                get { return rimColorRampScale; }
                set { rimColorRampScale = value; }
            }

            [ParserTarget("rimColorRampOffset")]
            private Vector2Parser rimColorRampOffsetSetter
            {
                get { return rimColorRampOffset; }
                set { rimColorRampOffset = value; }
            }

            [ParserTarget("Gradient")]
            public Gradient rimColorRampGradientSetter
            {
                set
                {
                    // Generate the ramp from a gradient 
                    Texture2D ramp = new Texture2D(512, 1);
                    Color[] colors = ramp.GetPixels(0);
                    for (int i = 0; i < colors.Length; i++)
                    {
                        // Compute the position in the gradient 
                        float k = (float)i / colors.Length;
                        colors[i] = value.ColorAt(k);
                    }
                    ramp.SetPixels(colors, 0);
                    ramp.Apply(true, false);

                    // Set the color ramp 
                    rimColorRamp = ramp;
                }
            }

            // LightDirection, default = (1,0,0,0)
            [ParserTarget("localLightDirection")]
            public Vector4Parser localLightDirectionSetter
            {
                get { return localLightDirection; }
                set { localLightDirection = value; }
            }

            // Resource Map (RGB), default = "black" { }
            [ParserTarget("resourceMap")]
            public Texture2DParser resourceMapSetter
            {
                get { return resourceMap; }
                set { resourceMap = value; }
            }

            [ParserTarget("resourceMapScale")]
            private Vector2Parser resourceMapScaleSetter
            {
                get { return resourceMapScale; }
                set { resourceMapScale = value; }
            }

            [ParserTarget("resourceMapOffset")]
            private Vector2Parser resourceMapOffsetSetter
            {
                get { return resourceMapOffset; }
                set { resourceMapOffset = value; }
            }

            // Constructors
            public ScaledPlanetRimAerialLoader () : base() { }
            public ScaledPlanetRimAerialLoader (string contents) : base (contents) { }
            public ScaledPlanetRimAerialLoader (Material material) : base(material) { }
        }
    }
}

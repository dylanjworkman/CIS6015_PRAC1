#version 450 core

layout(binding = 0) uniform sampler2D ColTexture;

in float Intensity;
in vec2 TexCoord;

out vec4 FragColor; // Color that will be used for the fragment

//////////////////////////////////////////////////////////////////
// main()
//////////////////////////////////////////////////////////////////
void main()
{
    //multiple attempts made to create tesselation shading have proven unsuccessful

}
using System;
using OpenTK;

namespace DTCEngine
{
    public class RendererFile_0 : GameWindow
    {
        Form1.merger m = new Form1.merger(); 
        public virtual void UpdateOnceFrame()
        {
            // engine specific code
        }
        public virtual void RenderScene()
        {
            // engine specific code

            m.placeholdermerger_0(); // contains scene object, normals, lighting, texture matrices etc...
        }
        public virtual void OnLoad() 
        {

        }
    }
}

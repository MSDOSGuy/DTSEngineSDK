using System;
using OpenTK;
using OpenTK.Graphics;
using System.Drawing;

namespace DTCEngine
{

    public class RendererFile : RendererFile_0
    {

      public override void UpdateOnceFrame() // called once per frame
      {
          



      }      
      public override void RenderScene() // intialized once 
      {
            GL.Clear(ClearBufferMask.ColorBufferBit);
            GL.ClearColor(Color.Black); 
            


      }
        public override void OnLoad() // called at the beginning of the program
        {


          
        }
    }
}

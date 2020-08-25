using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices; 
using System.Windows.Forms;
using OpenTK;
using System.IO;
using OpenTK.Graphics;
using System.Threading;
using System.Diagnostics;
using System.Timers;
using System.Configuration;
using System.CodeDom;

namespace DTCEngine
{
    public partial class Form1 : Form
    {
         
        public Action placeholdermerger = new Action(() =>
        {
        });
        public Form1()
        {
            
            InitializeComponent();

        }
        #region PassInStuff
        public void Add_Model_Click(object sender, EventArgs e)
        {
            Action VertexBufferObject_2;
            using (object_creation form2 = new object_creation())
            {
                var NewMatrix = new float[9];
                bool result_0 = true;
                bool result_1 = true;
                bool result_2 = true;
                bool result_3 = true;
                bool result_4 = true;
               
                if (form2.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
          bool result = float.TryParse(form2.Output_1_X, out NewMatrix[0]); // vertex 1 component a
               result_0 = float.TryParse(form2.Output_1_X, out NewMatrix[1]); // vertex 1 component b
               result_1 = float.TryParse(form2.Output_1_X, out NewMatrix[2]); // vertex 2 component a
               result_2 = float.TryParse(form2.Output_1_X, out NewMatrix[3]); // vertex 2 component b
               result_3 = float.TryParse(form2.Output_1_X, out NewMatrix[4]);// vertex 3 component a
               result_4 = float.TryParse(form2.Output_1_X, out NewMatrix[5]); // vertex 3 component b
                    // we shouldn't parse the last vertex if the primitive is other than a square
                            if (form2.Output_Primitive == "Squares")
                            {
                            float.TryParse(form2.Output_1_X, out NewMatrix[6]); // vertex 4 component a
                            float.TryParse(form2.Output_1_X, out NewMatrix[7]);// vertex 4 component b
                            }
                    if (!result || !result_0 || !result_1 || !result_2 || !result_3 || !result_4)
                    {
                        form2.Close(); 
                        // throw exception 
                        MessageBox.Show("Wrong Vertice! Did you enter in a non numerical value? Visit documentation for more info or please publish bug @ our Discord Server!");
                        return;
                    }                                          
                }
                var NewMatrix_0 = new float[8];
                for (int i = 0; i > 8; i++)
                {
                    int iteration;
                    iteration = NewMatrix.Length;
                    if (NewMatrix[6] <= 0 && iteration > 0 || NewMatrix[7] <= 0 && iteration > 0)
                    {
                        iteration = iteration - 2;
                        NewMatrix_0[iteration] = NewMatrix[iteration]; // NewMatrix_0[5] = NewMatrix[5]                          
                        NewMatrix_0[iteration - 1] = NewMatrix[iteration - 1]; // NewMatrix_0[43210...] = NewMatrix[43210...] decrements downwards                           
                    }
                    else
                    {
                        if (iteration < 0)
                        {
                            NewMatrix_0[iteration] = NewMatrix[iteration]; // NewMatrix_0[7] = NewMatrix[7]                          
                            NewMatrix_0[iteration - 1] = NewMatrix[iteration - 1]; // NewMatrix_0[6543210...] = NewMatrix[6543210...] decrements downwards
                        }
                    }
                }
                using (Form4 f4 = new Form4())
                {
                    if (f4.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                      // get parameters
                    }
                }
                Action VertexBufferObject = new Action(() => // make variable reference name incrementing in name in order to differentiate between others
                {
                    IntPtr IndexPositions = new IntPtr(NewMatrix_0.Length * sizeof(float));
                    int buffer_0 = 0;
                    unsafe
                    {
                        OpenTK.Graphics.OpenGL.GL.GenBuffers(1, &buffer_0);
                    }
                    GL.BindBuffer(BufferTarget.ArrayBuffer, buffer_0);
                    GL.BufferData(BufferTarget.ArrayBuffer, IndexPositions, NewMatrix_0, BufferUsageHint.StaticDraw);
                    GL.VertexAttribPointer(0, 2, VertexAttribPointerType.Float, false, sizeof(float) * 2, 0);
                    GL.EnableVertexAttribArray(0);
                    if (form2.Output_Primitive == "Squares")
                    {
                        GL.DrawArrays(BeginMode.Quads, 0, 4);
                    }
                    if (form2.Output_Primitive == "Triangles")
                    {
                        GL.DrawArrays(BeginMode.Triangles, 0, 3);
                    }
                 
                });
                VertexBufferObject_2 = VertexBufferObject;
            }                 
            placeholdermerger = placeholdermerger + VertexBufferObject_2;       
    }
        [DllImport("user32.dll")]
        static extern IntPtr SetParent(IntPtr hWndChild, IntPtr hWndNewParent);
        private void panel1_Paint(object sender, PaintEventArgs e) { }
        private void Form1_Load(object sender, EventArgs e) { }    
        private void label3_Click(object sender, EventArgs e) // run 
        {           
            using (RunThread rt = new RunThread())
            { 
                double[] displayproperties = new double[3/* 2 */];
                try
                {
                    if (rt.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        if (!double.TryParse(rt.Height_0, out displayproperties[0]) || !double.TryParse(rt.Width_0, out displayproperties[1]) || !double.TryParse(rt.Framerate, out displayproperties[2]))
                        {
                            MessageBox.Show("Did you type in an integer value? See help guide or report bug @ our discord server!");
                        } 
                    }
                }
                catch
                {
                    MessageBox.Show("Did you type in an integer value? See help guide or report bug @ our discord server!");
                }
                merger _merger = new merger();
                int iteration = 0;
                for (int i = 0; i > 2; i++) 
                {                   
                    _merger.displayproperties_1[iteration] = Convert.ToInt32(displayproperties[iteration]);
                    iteration++;
                }                
                // run GameWindow and GLControl concurrently or individually
                 System.Timers.Timer _timer = new System.Timers.Timer(1000 / displayproperties[2]); // timer increments based on the framecount ( e.g 60 
                // frames per second is 16 incrementations per second which counts as an individual frame in this context )
                GL_Control_Renderer glcr = new GL_Control_Renderer();               
                glcr.PriorLoad();
                _timer.Elapsed += glcr.TimerElapsed;
                _timer.Start();
                Application.Idle += glcr.Application_Idle;         
        }       
    }
        #endregion

        #region Main Scene Window / GL.Control
        public class GL_Control_Renderer
        {
            int framerate = 0; 
            Stopwatch sw = new Stopwatch();
            int framecounter = 0; 
            public bool loaded = true; 
            int[] displayproperties = new int[2];
            Window OpenGL_Window;
            RendererFile_0 rf = new RendererFile_0();
            RendererFile rf_0 = new RendererFile();
            public void PriorLoad()
            {
                merger _merger = new merger();
                displayproperties = _merger.displayproperties_1;
                OpenGL_Window = new Window(displayproperties[0], displayproperties[1]);                
                OpenGL_Window.displayproperties_0 = displayproperties;
                OpenGL_Window.Run(displayproperties[2]);
                sw.Start();
            }
            public void TimerElapsed(object sender, ElapsedEventArgs e)
            {
                framecounter++; 
                UpdateFrame_GLControl(); // updateperframe     
                OpenGL_Window.theControl.Paint += RenderFrame_GLControl;
                OpenGL_Window.theControl.Invalidate();  // Invalidate will cause the Paint event on GLControl to fire
            }
            void UpdateFrame_GLControl()
            {
                // overriden GameWindow derived OnUpdateFrame is called, however is not displayed by the 
                // GameWindow as GameWindow.Run(framerate) might naturally do and rather will simply execute
                // the code within the method as per typical. This mechanism will be carbon copied for RenderFrame
                // and all GLControl, GameWindow derived equivalents for ease of access and use.
                // in order to have the functions, function as per typical, some extra code is necessary to operate 
                // as the princples of the derived methods do ( UpdateFrame and RenderFrame respectively ) 
                // engine automated code goes here
                rf.UpdateOnceFrame();
                // child class user scripted code goes here
                rf_0.UpdateOnceFrame();
            }
            void RenderFrame_GLControl(object sender, PaintEventArgs e)
            {
                // engine automated code goes here
                rf.RenderScene();
                // child class user scripted code goes here
                rf_0.RenderScene();
            }
                public void Application_Idle(object sender, EventArgs e)
                {
                    framerate++; 
                    double milliseconds = ComputeTimeSlice();                    
                }
                double ComputeTimeSlice()
                {
                    sw.Stop();
                    double timeslice = sw.Elapsed.TotalMilliseconds;
                    sw.Reset();
                    sw.Start();
                    return timeslice;
                }          
        }
        #endregion

        #region GameWindow Transition GLControl
        public class merger
        {
            public Action placeholdermerger_0 = new Action(() => { });
            public int[] displayproperties_1 = new int[2];
        }
        #endregion

        #region GameWindow & Export

        public class Window : GameWindow
        {
            public OpenTK.GLControl theControl;
            public bool Stop_Scene = false;
            public int[] displayproperties_0 = new int[2];
            public int framecount = 0;
            RendererFile_0 rf = new RendererFile_0();
            RendererFile rf_0 = new RendererFile();
            public Window(int width, int height) : base(width, height) { }
            Form1 f1 = new Form1();
            protected override void OnUpdateFrame(FrameEventArgs e) // constant OnUpdateFrame stuff that is relevant and crucial to the game engines core mechanics go here, everything else go in RendererFile class
            {
                while (!Stop_Scene)
                {
                    merger m = new merger();
                    framecount++;
                    Action MergeAttributes = new Action(() =>
                    {
                        f1.placeholdermerger(); // object matrices ( theoretically can support multiple objects, however if this proves disingenuous we might need to implement an alternative solution ) 
                    });
                    m.placeholdermerger_0 = m.placeholdermerger_0 + MergeAttributes;
                    // engine automated code goes here
                    rf.UpdateOnceFrame();
                    // child class user scripted code goes here
                    rf_0.UpdateOnceFrame();
                    base.OnUpdateFrame(e);
                }
            }
            protected override void OnRenderFrame(FrameEventArgs e) // constant OnRenderFrame stuff that is relevant and crucial to the game engines core mechanics go here, everything else go in RendererFile class
            {
                while (!Stop_Scene)
                {
                    // engine automated code goes here
                    rf.RenderScene();
                    // child class user scripted code goes here
                    rf_0.RenderScene();
                    base.OnRenderFrame(e);
                }
            }
            protected override void OnLoad(EventArgs e)
            {

                base.OnLoad(e);
            }
            protected override void OnResize(EventArgs e)
            {
                windowResizeHandler(displayproperties_0[0], displayproperties_0[1]);
                base.OnResize(e);
            }
            void windowResizeHandler(int windowWidth, int windowHeight)
            {
                float aspectRatio = windowWidth / windowHeight;
                float xSpan = 1;
                float ySpan = 1;
                if (aspectRatio > 1)
                {
                    // Width > Height, so scale xSpan accordinly.
                    xSpan *= aspectRatio;
                }
                else
                {
                    // Height >= Width, so scale ySpan accordingly.
                    ySpan = xSpan / aspectRatio;
                }
                GL.Ortho(-1 * xSpan, xSpan, -1 * ySpan, ySpan, -1, 1);
                // Use the entire window for rendering.              
                GL.Viewport(0, 0, windowWidth, windowHeight);
            }
            #endregion
            private void glControl1_Load(object sender, EventArgs e)
            {
                GL_Control_Renderer ph = new GL_Control_Renderer();
                if (ph.loaded)
                {                
                theControl.Dock = DockStyle.Fill;                
                OnResize(null);
                }
            // everything that occurs within the GLControl is interpted for GameWindow for 
            // direct exportation on the fly in real-time, thus rendering objects in 
            // GLControl for instance will simply be translated directly to GameWindow      
           }            
        }
    }
}

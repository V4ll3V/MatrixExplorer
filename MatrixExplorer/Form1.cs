using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenTK;
using OpenTK.Graphics;
using OpenTK.Input;
using OpenTK.Graphics.OpenGL;


namespace MatrixExplorer
{
    public partial class Form1 : Form
    {
        private bool loaded = false;
        bool dragStart = false;
        Matrix4d modelViewMatrix = new Matrix4d();
        Matrix4d projectionMatrix = new Matrix4d();
        _3dObject square;
        public Form1()
        {
            InitializeComponent();
        }
        private void glControl1_Load(object sender, EventArgs e)
        {
            loaded = true;
            initLightning();
            GL.ClearColor(Color.White);
            SetupViewport();
            square = new _3dObject();
            render();
        }
        private void SetupViewport()
        {
            int w = glControl1.Width;
            int h = glControl1.Height;

            GL.Viewport(0, 0, w, h); // Use all of the glControl painting area
            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadIdentity();
            GL.Ortho(-35, 35, -35, 35, -35, 35); // Bottom-left corner pixel has coordinate (0, 0)

        }
        private void initLightning()
        {
            //Source: http://www.rolandk.de/index.php?option=com_content&view=article&id=60:opengl-rendering-mit-opentk&catid=10:grafik&Itemid=6
            GL.ClearColor(Color.White);
            GL.ClearDepth(1.0f);

            //Enable depth testing
            GL.Enable(EnableCap.DepthTest);
            GL.DepthFunc(DepthFunction.Lequal);

            //Enable lighting
            GL.Light(LightName.Light1, LightParameter.Ambient, OpenTK.Graphics.Color4.White);
            GL.Light(LightName.Light1, LightParameter.Diffuse, OpenTK.Graphics.Color4.Green);
            GL.Light(LightName.Light1, LightParameter.Position, (new Vector4(0f, 0f, 0f, -5f)));
            GL.Light(LightName.Light1, LightParameter.SpotDirection, (new Vector4(0f, 0f, 1f, 0f)));
            GL.Enable(EnableCap.Light1);
            GL.Enable(EnableCap.Lighting);

            //Enable Backfaceculling
            GL.Enable(EnableCap.CullFace);
        }

        void render()
        {
            if (!loaded)
                return;
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
            //Get the current value of the Modelview Matrix
            GL.GetDouble(GetPName.ModelviewMatrix, out modelViewMatrix);
            //Get the current value of the Projection Matrix
            GL.GetDouble(GetPName.ProjectionMatrix, out projectionMatrix);
            if (modelviewButton.Checked == true)
            {
                GL.MatrixMode(MatrixMode.Modelview);
            }
            if (projectionButton.Checked == true)
            {
                GL.MatrixMode(MatrixMode.Projection);
            }
            GL.LoadIdentity();
            //translate an rotate then draw the square with the given size value of the _3dObject
            GL.Translate(square.getTranslation());
            GL.Rotate(square.getAngle(), square.getRotation());
            square.DrawSquare(square.getObjectSize());
            //function to set the values of the matrices to the diffrent textboxes
            setModelViewMatrixValues();
            setProjectionMatrixValues();

            glControl1.SwapBuffers();
        }
        //Set the Modelview Matrix values
        private void setModelViewMatrixValues()
        {

            double column0X = Math.Round(modelViewMatrix.Column0.X, 3);
            double column0Y = Math.Round(modelViewMatrix.Column0.Y, 3);
            double column0Z = Math.Round(modelViewMatrix.Column0.Z, 3);
            double column1X = Math.Round(modelViewMatrix.Column1.X, 3);
            double column1Y = Math.Round(modelViewMatrix.Column1.Y, 3);
            double column1Z = Math.Round(modelViewMatrix.Column1.Z, 3);
            double column2X = Math.Round(modelViewMatrix.Column2.X, 3);
            double column2Y = Math.Round(modelViewMatrix.Column2.Y, 3);
            double column2Z = Math.Round(modelViewMatrix.Column2.Z, 3);

            textBox1.Text = column0X.ToString();
            textBox2.Text = column0Y.ToString();
            textBox3.Text = column0Z.ToString();
            textBox4.Text = column1X.ToString();
            textBox5.Text = column1Y.ToString();
            textBox6.Text = column1Z.ToString();
            textBox7.Text = column2X.ToString();
            textBox8.Text = column2Y.ToString();
            textBox9.Text = column2Z.ToString();
        }
        //Set the Projection Matrix values
        private void setProjectionMatrixValues()
        {

            double column0X = Math.Round(projectionMatrix.Column0.X, 3);
            double column0Y = Math.Round(projectionMatrix.Column0.Y, 3);
            double column0Z = Math.Round(projectionMatrix.Column0.Z, 3);
            double column1X = Math.Round(projectionMatrix.Column1.X, 3);
            double column1Y = Math.Round(projectionMatrix.Column1.Y, 3);
            double column1Z = Math.Round(projectionMatrix.Column1.Z, 3);
            double column2X = Math.Round(projectionMatrix.Column2.X, 3);
            double column2Y = Math.Round(projectionMatrix.Column2.Y, 3);
            double column2Z = Math.Round(projectionMatrix.Column2.Z, 3);

            textBox10.Text = column0X.ToString();
            textBox11.Text = column0Y.ToString();
            textBox12.Text = column0Z.ToString();
            textBox13.Text = column1X.ToString();
            textBox14.Text = column1Y.ToString();
            textBox15.Text = column1Z.ToString();
            textBox16.Text = column2X.ToString();
            textBox17.Text = column2Y.ToString();
            textBox18.Text = column2Z.ToString();
        }

        //Diffrent Events, mostly self explaining
        private void rotateAngleValueChanged(object sender, EventArgs e)
        {
            square.setAngle(Convert.ToInt32(rotateAngle.Value));
            render();
            Invalidate();
        }
        private void rotateXValueChanged(object sender, EventArgs e)
        {
            square.setXRotate(Convert.ToInt32(rotateX.Value));
            Invalidate();
        }

        private void rotateYValueChanged(object sender, EventArgs e)
        {
            square.setYRotate(Convert.ToInt32(rotateY.Value));
            Invalidate();
        }

        private void rotateZValueChanged(object sender, EventArgs e)
        {
            square.setZRotate(Convert.ToInt32(rotateZ.Value));
            Invalidate();
        }
        private void translateXValueChanged(object sender, EventArgs e)
        {
            square.setXTranslate(Convert.ToInt32(translateX.Value));
            render();
            Invalidate();
        }

        private void translateYValueChanged(object sender, EventArgs e)
        {
            square.setYTranslate(Convert.ToInt32(translateY.Value));
            render();
            Invalidate();
        }

        private void translateZValueChanged(object sender, EventArgs e)
        {
            square.setZTranslate(Convert.ToInt32(translateZ.Value));
            render();
            Invalidate();
        }

        private void glControl1MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (dragStart == true)
            {
                //Set the current mosue Position to the objects X and Y Rotation Value
                square.setXRotate(e.X);
                square.setYRotate(e.Y);
                //Lazy way to set angle (toDo: convert mouse coordinates to world coordinates)
                square.setAngle(e.X + e.Y);
                render();
                Invalidate();
            }
        }

        private void canvasMouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //start of Mouse drag
            dragStart = true;
        }

        private void canvasMouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //stop Mouse Drag
            dragStart = false;
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            square.setObjectSize(hScrollBar1.Value);
            render();
        }

        private void modelviewButton_CheckedChanged(object sender, EventArgs e)
        {
            if (modelviewButton.Checked == true)
            {
                projectionButton.Checked = false;
            }
           
        }

        private void projectionButton_CheckedChanged(object sender, EventArgs e)
        {
            if (projectionButton.Checked == true)
            {
                modelviewButton.Checked = false;
            }
        }
    }
}

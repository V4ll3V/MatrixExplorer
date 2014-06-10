using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK;
using OpenTK.Graphics;
using OpenTK.Input;
using OpenTK.Graphics.OpenGL;

namespace MatrixExplorer
{
    class _3dObject
    {
        private int xRotate, yRotate, zRotate, xTranslate, yTranslate, zTranslate, angle = 0, objectSize =10;
        public _3dObject()
        {
        }
        //get translation vector
        public Vector3d getTranslation()
        {

            Vector3d translationVec = new Vector3d(xTranslate, yTranslate, zTranslate); ;
            return translationVec;
        }
        //get rotation vector
        public Vector3d getRotation()
        {

            Vector3d rotationVec = new Vector3d(xRotate, yRotate, zRotate);
            return rotationVec;
        }
        //Draw the object (in this case it's just a square)
        public void DrawSquare(float length)
        {
            GL.Begin(PrimitiveType.Quads);	//oben 
            GL.Vertex3(length, length, -length);
            GL.Vertex3(-length, length, -length);
            GL.Vertex3(-length, length, length);
            GL.Vertex3(length, length, length);
            GL.End();

            GL.Begin(PrimitiveType.Quads);	//unten
            GL.Vertex3(length, -length, length);
            GL.Vertex3(-length, -length, length);
            GL.Vertex3(-length, -length, -length);
            GL.Vertex3(length, -length, -length);
            GL.End();

            GL.Begin(PrimitiveType.Quads);	//vorne   
            GL.Vertex3(length, length, length);
            GL.Vertex3(-length, length, length);
            GL.Vertex3(-length, -length, length);
            GL.Vertex3(length, -length, length);
            GL.End();

            GL.Begin(PrimitiveType.Quads);   //hinten
            GL.Vertex3(length, -length, -length);
            GL.Vertex3(-length, -length, -length);
            GL.Vertex3(-length, length, -length);
            GL.Vertex3(length, length, -length);
            GL.End();

            GL.Begin(PrimitiveType.Quads);  //links
            GL.Vertex3(-length, length, length);
            GL.Vertex3(-length, length, -length);
            GL.Vertex3(-length, -length, -length);
            GL.Vertex3(-length, -length, length);
            GL.End();

            GL.Begin(PrimitiveType.Quads);    //rechts
            GL.Vertex3(length, length, -length);
            GL.Vertex3(length, length, length);
            GL.Vertex3(length, -length, length);
            GL.Vertex3(length, -length, -length);
            GL.End();
        }
        //getter and setter for variables
        public int getAngle()
        {
            return this.angle;
        }
        public int getObjectSize()
        {
            return this.objectSize;
        }
        public void setAngle(int Angle)
        {
            this.angle = Angle;
        }
        public void setXRotate(int XRotate)
        {
            this.xRotate = XRotate;
        }
        public void setYRotate(int yRotate)
        {
            this.yRotate = yRotate;
        }
        public void setZRotate(int zRotate)
        {
            this.zRotate = zRotate;
        }
        public void setXTranslate(int xTranslate)
        {
            this.xTranslate = xTranslate;
        }
        public void setYTranslate(int yTranslate)
        {
            this.yTranslate = yTranslate;
        }
        public void setZTranslate(int zTranslate)
        {
            this.zTranslate = zTranslate;
        }
        public void setObjectSize(int size)
        {
            this.objectSize = size;
        }
       
    }
}

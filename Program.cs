using System.Runtime.Intrinsics.X86;

namespace G_NET_9_OOP01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region PART 01

            #region Question 01
            //======================================================================
            //Q1: Explain with code example how class and struct behave differently
            //======================================================================

            #region 1.Reference Type vs Value Type

            //// class is reference type - struct is value type
            //PointClass pc1 = new PointClass(1, 2);
            //PointClass pc2 = pc1;

            //Console.WriteLine($"Point 1 (CLASS): {pc1}");
            //Console.WriteLine($"Point 2 (CLASS): {pc2}");


            //pc2.X = 20;

            //Console.WriteLine($"Point 1 (CLASS): {pc1}");
            //Console.WriteLine($"Point 2 (CLASS): {pc2}");
            //// since class is reference type, both pc1 and pc2 change when modifying any of them

            //PointStruct ps1 = new PointStruct(1,2);
            //PointStruct ps2 = ps1;

            //Console.WriteLine();
            //Console.WriteLine($"Point 1 (STRUCT): {ps1}");
            //Console.WriteLine($"Point 2 (STRUCT): {ps2}");

            //ps2.X = 20;

            //Console.WriteLine($"Point 1 (STRUCT): {ps1}");
            //Console.WriteLine($"Point 2 (STRUCT): {ps2}");
            //// since struct is value type, ps2 onlu takes a copy of ps1, so ps1 doesn't change when modifying ps2
            #endregion

            #region 2.Default CTOR

            // CLASS
            //PointClass pc1 = new PointClass(); // Error because default CTOR no longer exists after creating another CTOR
            //PointClass pc2 = new PointClass(1, 2); // only the CTOR we created works

            // STRUCT
            //PointStruct ps1 = new PointStruct();
            //PointStruct ps2 = new PointStruct(1,2);
            // both works since default CTOR still exist
            #endregion

            // 3. Classes support inheritance while structs don't support inheritance

            // 4. Class can be null, but struct cannot (unless nullable)

            // 5. Class is stored in heap while reference is in stack, struct is stored in stack

            #endregion

            #region Question 02
            //======================================================================
            //Q2 : Explain the difference between public and private access modifiers with an example.
            //======================================================================

            // we made 2 new attributes in PointClass
            // Z ==> Private
            // W ==> Public

            //PointClass pc1 = new PointClass(1, 2);
            //pc1.Z = 10; // ERROR: class member is private and cannot be accessed in this class (main)
            //pc1.W = 20; // no error: W can be accessed anywhere since it's public

            #endregion

            #region Question 03
            //======================================================================
            //Q3 : Describe the steps to create and use a class library in Visual Studio.
            //======================================================================


            #endregion

            #region Question 04
            //======================================================================
            //Q4 : What is a class library? Why do we use class libraries?
            //======================================================================


            #endregion

            #endregion
        }
    }
}

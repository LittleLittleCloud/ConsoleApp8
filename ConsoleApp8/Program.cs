using System;
using Tensorflow;
using static Tensorflow.Binding;


namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            tf.compat.v1.disable_eager_execution();
            var session = Session.LoadFromSavedModel("./");

            foreach(var op in session.graph)
            {
                Console.WriteLine(op.name);
                if(op.NumInputs > 0)
                {
                    Console.WriteLine(op.inputs[0].name);
                }
            }
        }
    }
}

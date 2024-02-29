using System;

namespace TypeCasting
{
	// 'Class' is also a type
	public class MyClass
	{
		public string name;
	}

	public class Program
	{
        public delegate string delegateName(string name);//declaration of the delegate
        //now we are using the delegate without the 
		static void Main(string[] args)
		{
//anonymouse function: delegate defination without name of the delegate
            delegateName someName = delegate(string name){
                return `return ${name}`;
            }
//statement lamda : no need to write the delegate like the anonymous function + use of {}
            delegateName statementLamda2 =(name) =>{
                return $"Hello {name}"
            }
//Expression lamda : no need to write the delegate like the anonymous function + !use of {}
            delegateName ExpressionLamda2 =(name) =>{
                return $"Hello {name}"
            }
 

		 
		}
	}
}
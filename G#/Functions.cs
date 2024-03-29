namespace Wall_E
{
    public class Functions
    {
        private static Dictionary<string, Function> functions = new();

        public Functions()
        {
            functions=new();
        }

        public static bool Contains(string name)
        {
            if (functions.ContainsKey(name)) return true;
            return false;
        }

        public static Function Get(string name)
        {
            if (functions.ContainsKey(name)) return functions[name];
            throw new ERROR(ERROR.ErrorType.SemanticError, "function " + name + " is not defined");
        }

        public static void AddFun(string name, Function function = null!)
        {
            if (functions.ContainsKey(name))
            {
                functions[name] = function;
            }
            else functions.Add(name, function);
        }

        public static void Fun()
        {
            AddFun("draw");
            AddFun("measure");
            AddFun("line");
            AddFun("segment");
            AddFun("circle");
            AddFun("ray");
            AddFun("arc");
            AddFun("intersect");
            AddFun("count");
            AddFun("randoms");
            AddFun("points");
            AddFun("samples");
            AddFun("point");
        }
    }
}
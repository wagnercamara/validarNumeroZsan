namespace validarNumeroZsan
{
    public class ValidarUltimasCasas
    {
        public bool Validar(string numero)
        {
            char[] arr;
            int x = numero.Length;
            int i = x - 4;

            arr = numero.ToCharArray(0,x);
            if(arr[0] == '5')
            {
                while(arr[i] == '9')
                {
                    i++;
                    if(i == x)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}

namespace Traductor.Models
{
    public class TraductorModel
    {
        private readonly Dictionary<char, string> svgDictionary = new Dictionary<char, string>
        {

                    { '0', "../Caracteres/0.svg" },
                    { '1', "../Caracteres/1.svg" },
                    { '2', "../Caracteres/2.svg" },
                    { '3', "../Caracteres/3.svg" },
                    { '4', "../Caracteres/4.svg" },
                    { '5', "../Caracteres/5.svg" },
                    { '6', "../Caracteres/6.svg" },
                    { '7', "../Caracteres/7.svg" },
                    { '8', "../Caracteres/8.svg" },
                    { '9', "../Caracteres/9.svg" },
                    { 'a', "../Caracteres/a.svg" },
                    { 'b', "../Caracteres/b.svg" },
                    { 'c', "../Caracteres/c.svg" },
                    { 'd', "../Caracteres/d.svg" },
                    { 'e', "../Caracteres/e.svg" },
                    { 'f', "../Caracteres/f.svg" },
                    { 'g', "../Caracteres/g.svg" },
                    { 'h', "../Caracteres/h.svg" },
                    { 'i', "../Caracteres/i.svg" },
                    { 'j', "../Caracteres/j.svg" },
                    { 'k', "../Caracteres/k.svg" },
                    { 'l', "../Caracteres/l.svg" },
                    { 'm', "../Caracteres/m.svg" },
                    { 'n', "../Caracteres/n.svg" },
                    { 'o', "../Caracteres/o.svg" },
                    { 'p', "../Caracteres/p.svg" },
                    { 'q', "../Caracteres/q.svg" },
                    { 'r', "../Caracteres/r.svg" },
                    { 's', "../Caracteres/s.svg" },
                    { 't', "../Caracteres/t.svg" },
                    { 'u', "../Caracteres/u.svg" },
                    { 'v', "../Caracteres/v.svg" },
                    { 'w', "../Caracteres/w.svg" },
                    { 'x', "../Caracteres/x.svg" },
                    { 'y', "../Caracteres/y.svg" },
                    { 'z', "../Caracteres/z.svg" }
        };
            
            public string ObtenerRutaSvg(char letra)
            {
                if (svgDictionary.ContainsKey(letra))
                {
                    return svgDictionary[letra];
                }
                else
                {
                    return "../Caracteres/3.svg";
                }
            }
        }
    }


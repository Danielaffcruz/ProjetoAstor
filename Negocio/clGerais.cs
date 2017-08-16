using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class clGerais
    {
        public string RemoveAcentos(string texto)
        {
            //funcao para remover caracteres acentuados
            string[] acentos = new string[] { "ç", "Ç", "á", "é", "í", "ó", "ú", "ý", "Á", "É", "Í", "Ó", "Ú", "Ý", "à", "è", "ì", "ò", "ù", "À", "È", "Ì", "Ò", "Ù", "ã", "õ", "ñ", "ä", "ë", "ï", "ö", "ü", "ÿ", "Ä", "Ë", "Ï", "Ö", "Ü", "Ã", "Õ", "Ñ", "â", "ê", "î", "ô", "û", "Â", "Ê", "Î", "Ô", "Û", "'" };
            string[] semAcento = new string[] { "c", "C", "a", "e", "i", "o", "u", "y", "A", "E", "I", "O", "U", "Y", "a", "e", "i", "o", "u", "A", "E", "I", "O", "U", "a", "o", "n", "a", "e", "i", "o", "u", "y", "A", "E", "I", "O", "U", "A", "O", "N", "a", "e", "i", "o", "u", "A", "E", "I", "O", "U", "" };
            for (int i = 0; i < acentos.Length; i++)
            {
                texto = texto.Replace(acentos[i], semAcento[i]);
            }
            //troca os caracteres especiais da string por ""
            string[] caracteresEspeciais = { "\\.", ",", "-", ":", "\\(", "\\)", "ª", "\\|", "\\\\", "°" };
            for (int i = 0; i < caracteresEspeciais.Length; i++)
            {
                texto = texto.Replace(caracteresEspeciais[i], "");
            }
            //troca os espacos no inicio por ""
            texto = texto.Replace("^\\s+", "");
            //troca os espacos no inicio por ""
            texto = texto.Replace("\\s+$", "");
            //troca os espacos duplicados, tabulacoes e etc por  " "
            texto = texto.Replace("\\s+", " ");
            return texto;
        }
    }
}

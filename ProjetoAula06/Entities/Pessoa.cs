using System.Text.RegularExpressions;

namespace ProjetoAula06.Entities;
/// <summary>
/// Modelo de entidade
/// </summary>
public class Pessoa
{
    #region Atributos
    private Guid _id;
    private string _nome;
    private string _cpf;
    #endregion
    public int MyProperty { get; set; }

    #region Propriedades
    public Guid Id
    {
        get { return _id; }
        set { _id = value; }
    }

    public string Nome 
    {
        get { return _nome; }
        set {
            if (string.IsNullOrEmpty(value))
                throw new ArgumentNullException("O nome da pessoa é obrigatório");

            var regex = new Regex("^[A-Za-zÀ-Üà-ü\\s]{8,100}$"); //permite de A a Z maiúsculo e minúsculo, acentos, espaços e entre 8 a 100 caracteres

            if (!regex.IsMatch(value))
                throw new ArgumentException("O nome da pessoa deve ter somente texto de 8 a 100 caracteres");

            _nome = value; 
        }     
    }

    public string Cpf
    {
        get { return _cpf; }
        set {
            if (string.IsNullOrEmpty(value))
                throw new ArgumentNullException("O cpf é obrigatório.");

            var regex = new Regex("^[0-9]{11}$");
            if (!regex.IsMatch(value))
                throw new ArgumentException("O cpf da pessoa deve ter exatamente 11 dígitos (sem símbolos.)");
            _cpf = value; }
    }

    #endregion
}

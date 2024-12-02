class Conta
{
    public long numConta;
    protected string tipo;
    private string dono;
    private double saldo;
    private bool status;

    public Conta(string credista)
    {
        status = false;
        saldo = 0;  
    }

    public void Status()
    {
        GetNumConta();
        GetTipo();
        GetDono();
        GetSaldo();
        Console.WriteLine(@$"
        Status: {status}");
    }

    public void AbrirConta(string tipoConta)
    {
        status = true;

        if (tipoConta == "CC")
        {
            SetTipo("corrente");
            SetSaldo(50);
        }
        else if (tipoConta == "CP")
        {
            SetTipo("poupança");
            SetSaldo(150);
        }
        else 
        Console.WriteLine("Tipo de conta invalído");
    }
    public void FecharConta()
    {
        if (saldo > 0)
        {
            Console.WriteLine("Não é possível fechar uma conta com dinheiro");
        }
        else if(saldo < 0)
        {
            Console.WriteLine("Não é possível fechar a conta, conta em débito");
        }
        else
        {
            status = false;
        }
    }
    public void Depositar(double cash)
    {
        Console.WriteLine($"Saldo atual R${saldo}");
        Console.WriteLine($"Você depositou R${cash}");
        SetSaldo(cash);
        Console.WriteLine($"Novo saldo R${saldo}");
    }
    public double Sacar(int saque)
    {
        Console.WriteLine($"Saldo atual R${saldo}");
        Console.WriteLine($"Você quer sacar R${saque}");
        if (saldo - saque >= 0)
        {
            saldo -= saque;
            Console.WriteLine("Saque Disponível");
            Console.WriteLine($"Novo saldo R${saldo}");
            return saque;
        }
        else 
        Console.WriteLine("Saque Indisponível, cancelando operação");
        return 0;
    }

    public void PagarMensal()
    {} 

    public long GetNumConta()
    {
        return numConta;
    }    
    public void SetNumConta(long nConta)
    {
        numConta = nConta;
    }    

    public string GetTipo()
    {
        return tipo;
    }        
    public void SetTipo(string tipoConta)
    {
        tipo = tipoConta;
        Console.WriteLine($"Tipo da conta: {tipo}");   
    }

    public string GetDono()
    {
        return dono;
    }        
    public void SetDono(string salafrario)
    {
        dono = salafrario;
    }

    public double GetSaldo()
    {
        return saldo;
    } 
    public void SetSaldo(double deposito)
    {
        saldo =+ deposito;
    }
}
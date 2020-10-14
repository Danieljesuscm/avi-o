class aviao{
  public string nomeaviao;
  private int capacidadetanque;
  private int nivelcombustivel;
  public int quantidadepass;
  public int autonomiaaero;
  public int  horasvoo;
  private string nomepiloto;
  private string aeroportoatual;
  
  public int abasteceraeronave(){
    if (nivelcombustivel<capacidadetanque){
      return capacidadetanque - nivelcombustivel;

    }
    else{
      return capacidadetanque;
    }
  

      
  }
  public int voar (int distancia){
    if (distancia <= autonomiaaero){
      return horasvoo = horasvoo+distancia;
    }
    return horasvoo;
  }
  public void Setnomepiloto(string nomep){
    nomepiloto = nomep;

  }
  public string Getnomepiloto(){
    return nomepiloto;
  }
  public void Setaeroportoatual(string aerportoa){
    aeroportoatual = aerportoa;

  }
  public string Getaerporrtoatual(){
    return aeroportoatual;
  }

  public aviao(){
    nomeaviao = "Tam";
    capacidadetanque = 16000;
    nivelcombustivel = 10000;
    quantidadepass = 120;
    autonomiaaero = 36;
    horasvoo = 72 ;
    nomepiloto = "Cleber";
    aeroportoatual = "campinas";
  }
  public aviao(string nome,int cap, int nivel, int pass,int auto,int horas,string pilot, string aero){
    nomeaviao = nome;
    capacidadetanque = cap ;
    nivelcombustivel = nivel;
    quantidadepass = pass;
    autonomiaaero = auto;
    horasvoo = horas ;
    nomepiloto = pilot;
    aeroportoatual = aero;

  }


  
}

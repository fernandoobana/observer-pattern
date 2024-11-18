using ObserverPattern.ExemploCasoDeUso;

var namorada = new Namorada();
var sindico = new Sindico();
var vizinhoUltimoAndar = new VizinhoUltimoAndar();

var porteiro = new Porteiro();
porteiro.RegistrarObserver("NamoradoChegou", namorada);
porteiro.RegistrarObserver("NamoradoChegou", sindico);
porteiro.RegistrarObserver("PizzaChegou", vizinhoUltimoAndar);
porteiro.Monitorar();
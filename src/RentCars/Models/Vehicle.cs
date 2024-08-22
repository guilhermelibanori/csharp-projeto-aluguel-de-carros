using RentCars.Types;
namespace RentCars.Models;

//3 - Crie a classe `Vehicle`
public class Vehicle
{
  string _brand = "";
  string _model = "";
  bool _isRented = false;

  public string Brand
  {
    get { return _brand; }
    set { _brand = value; }
  }
  public string Model
  {
    get { return _model; }
    set { _model = value; }
  }
  public decimal Price { get; set; }

  public FuelType Fuel { get; set; }

  public int EngineCapacity { get; set; }

  public Color MainColor { get; set; }

  public int Year { get; set; }

  public double PricePerDay { get; set; }

  public bool IsRented
  {
    get { return _isRented; }
    set { _isRented = value; }
  }

}
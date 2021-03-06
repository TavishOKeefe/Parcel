using System;

namespace Parcels.Models
{
  public class Parcel
  {
    private string _height;
    private string _length;
    private string _width;
    private string _weight;

    public Parcel (string height, string length, string width, string weight)
    {
      _height = height;
      _length = length;
      _width = width;
      _weight = weight;
    }

    public string GetHeight()
    {
      return _height;
    }

    public void SetHeight(string newHeight)
    {
      _height = newHeight;
    }
    public string GetLength()
    {
      return _length;
    }

    public void SetLength(string newlength)
    {
      _length = newlength;
    }
    public string GetWidth()
    {
      return _width;
    }

    public void SetWidth(string newWidth)
    {
      _width = newWidth;
    }
    public string GetWeight()
    {
      return _weight;
    }

    public void SetWeight(string newWeight)
    {
      _weight = newWeight;
    }


  }
}

using System.Runtime.Serialization;
namespace DocumentModel;
/// <summary>
/// Basic color type. Contains name and RGB values.
/// </summary>

public abstract class Color: ModelElement
{
  ///// <summary>
  /////   Gets RGB value of the color.
  ///// </summary>
  //public RGB? ConvertToBool();

  ///// <summary>
  ///// Sets RGB value of the color.
  ///// </summary>
  ///// <param name="value">RGB hexadecimal value</param>
  //public void FromRGB(RGB value);

  ///// <summary>
  ///// Sets color from string value;
  ///// </summary>
  ///// <param name="value"></param>
  //public void FromString(string value);

  ///// <summary>
  ///// Gets value as string.
  ///// </summary>
  ///// <returns></returns>
  //public string? ToString();
}

public class Color<T> : ModelElement<T> where T : DX.OpenXmlElement
{
}

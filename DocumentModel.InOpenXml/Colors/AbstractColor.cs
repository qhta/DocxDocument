using System.Runtime.Serialization;
namespace DocumentModel;
/// <summary>
/// Basic color type. Contains name and RGB values.
/// </summary>

public abstract class AbstractColor: ModelElement
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

/// <summary>
/// Represents a color model element with a generic underlying Open XML element type.
/// </summary>
/// <typeparam name="T">The type of the underlying Open XML element represented by this color model element. Must derive from
/// DX.OpenXmlElement.</typeparam>
public abstract class AbstractColor<T> : ModelElement<T> where T : DX.OpenXmlElement
{
}

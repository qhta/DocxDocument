namespace DocumentModel.Interop.Word;

/// <summary>
/// Reserved for internal use.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._olecontrol?view=word-pia"/>
public partial interface _OLEControl
{
  /// <summary>
  /// The left.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._olecontrol.left?view=word-pia"/>
  public float Left { get; set; }

  /// <summary>
  /// The top.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._olecontrol.top?view=word-pia"/>
  public float Top { get; set; }

  /// <summary>
  /// The height.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._olecontrol.height?view=word-pia"/>
  public float Height { get; set; }

  /// <summary>
  /// The width.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._olecontrol.width?view=word-pia"/>
  public float Width { get; set; }

  /// <summary>
  /// The name.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._olecontrol.name?view=word-pia"/>
  public string Name { get; set; }

  /// <summary>
  /// The automation.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._olecontrol.automation?view=word-pia"/>
  public object Automation { get; }

  /// <summary>
  /// The alt html.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._olecontrol.althtml?view=word-pia"/>
  public string AltHTML { get; set; }
}

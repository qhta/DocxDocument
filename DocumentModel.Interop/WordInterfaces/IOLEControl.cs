namespace DocumentModel.Interop.Word;

/// <summary>
/// Reserved for internal use.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._olecontrol?view=word-pia"/>
public interface IOLEControl
{
  /// <summary>
  /// Gets or sets the distance, in points, between the left edge of the object and the left edge of the anchor.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._olecontrol.left?view=word-pia"/>
  public float Left { get; set; }

  /// <summary>
  /// Gets or sets the distance, in points, between the top edge of the object and the top edge of the anchor.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._olecontrol.top?view=word-pia"/>
  public float Top { get; set; }

  /// <summary>
  /// Gets or sets the height of the OLE control, in points.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._olecontrol.height?view=word-pia"/>
  public float Height { get; set; }

  /// <summary>
  /// Gets or sets the width of the OLE control, in points.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._olecontrol.width?view=word-pia"/>
  public float Width { get; set; }

  /// <summary>
  /// Gets or sets the name of the OLE control.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._olecontrol.name?view=word-pia"/>
  public string Name { get; set; }

  /// <summary>
  /// Gets the automation object for the OLE control.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._olecontrol.automation?view=word-pia"/>
  public object Automation { get; }

  /// <summary>
  /// Gets or sets the HTML representation used when the OLE control is saved as a web page.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._olecontrol.althtml?view=word-pia"/>
  public string AltHTML { get; set; }


  #region methods

/// <summary>
  /// Performs the select operation.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._olecontrol.select?view=word-pia"/>
  public void Select();

  #endregion methods
}

namespace DocumentModel.IApplication;

/// <summary>
/// Specifies whether the command bar combo box includes a label or not.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msocombostyle?view=office-pia` Ifor Office interop details.
/// </remarks>
public enum ComboStyle
{
  /// <summary>
  /// Combo box does not include a label.
  /// </summary>
  Normal,
  /// <summary>
  /// Combo box includes a label, specified by the Caption property of the combo box.
  /// </summary>
  Label
}


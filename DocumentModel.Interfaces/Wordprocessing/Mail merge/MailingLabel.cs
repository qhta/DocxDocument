namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents a mailing label.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailinglabel?view=word-pia"/>
public partial interface IMailingLabel : IModelObject
{
  /// <summary>
  /// Returns or sets whether a bar code is printed by default on mailing labels.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailinglabel.defaultprintbarcode?view=word-pia"/>
  public bool DefaultPrintBarCode { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Returns or sets the default printer tray used for laser labels.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailinglabel.defaultlasertray?view=word-pia"/>
  public PaperTray DefaultLaserTray { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Returns the custom labels collection.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailinglabel.customlabels?view=word-pia"/>
  public ICustomLabels CustomLabels { get; }

  /// <summary>
  /// Returns or sets the default mailing label name.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailinglabel.defaultlabelname?view=word-pia"/>
  public string DefaultLabelName { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Returns or sets whether labels are printed vertically.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.mailinglabel.vertical?view=word-pia"/>
  public bool Vertical { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
}

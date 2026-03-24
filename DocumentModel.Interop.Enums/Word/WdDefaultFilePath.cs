namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies a default folder for files related to Microsoft Word.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wddefaultfilepath?view=office-pia` for Office interop details.
/// </remarks>
public enum WdDefaultFilePath
{
  /// <summary>
  /// Documents path.
  /// </summary>
  DocumentsPath = 0,
  /// <summary>
  /// Pictures path.
  /// </summary>
  PicturesPath = 1,
  /// <summary>
  /// User templates path.
  /// </summary>
  UserTemplatesPath = 2,
  /// <summary>
  /// Workgroup templates path.
  /// </summary>
  WorkgroupTemplatesPath = 3,
  /// <summary>
  /// User Options path.
  /// </summary>
  UserOptionsPath = 4,
  /// <summary>
  /// Path for Auto Recover files.
  /// </summary>
  AutoRecoverPath = 5,
  /// <summary>
  /// Tools path.
  /// </summary>
  ToolsPath = 6,
  /// <summary>
  /// Tutorial path.
  /// </summary>
  TutorialPath = 7,
  /// <summary>
  /// Startup path.
  /// </summary>
  StartupPath = 8,
  /// <summary>
  /// Program path.
  /// </summary>
  ProgramPath = 9,
  /// <summary>
  /// Graphics filters path.
  /// </summary>
  GraphicsFiltersPath = 10,
  /// <summary>
  /// Text converters path.
  /// </summary>
  TextConvertersPath = 11,
  /// <summary>
  /// Proofing tools path.
  /// </summary>
  ProofingToolsPath = 12,
  /// <summary>
  /// Temp file path.
  /// </summary>
  TempFilePath = 13,
  /// <summary>
  /// Current folder path.
  /// </summary>
  CurrentFolderPath = 14,
  /// <summary>
  /// Style Gallery path.
  /// </summary>
  StyleGalleryPath = 15,
  /// <summary>
  /// Border art path.
  /// </summary>
  BorderArtPath = 19
}

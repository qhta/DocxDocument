namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies a default folder for files related to Microsoft Word.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wddefaultfilepath?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Interop.Word.WdDefaultFilePath")]
public enum DefaultFilePath
{
  /// <summary>
  /// Documents path.
  /// </summary>
  [InteropEnumValue("wdDocumentsPath")]
  DocumentsPath = 0,
  /// <summary>
  /// Pictures path.
  /// </summary>
  [InteropEnumValue("wdPicturesPath")]
  PicturesPath = 1,
  /// <summary>
  /// User templates path.
  /// </summary>
  [InteropEnumValue("wdUserTemplatesPath")]
  UserTemplatesPath = 2,
  /// <summary>
  /// Workgroup templates path.
  /// </summary>
  [InteropEnumValue("wdWorkgroupTemplatesPath")]
  WorkgroupTemplatesPath = 3,
  /// <summary>
  /// User Options path.
  /// </summary>
  [InteropEnumValue("wdUserOptionsPath")]
  UserOptionsPath = 4,
  /// <summary>
  /// Path for Auto Recover files.
  /// </summary>
  [InteropEnumValue("wdAutoRecoverPath")]
  AutoRecoverPath = 5,
  /// <summary>
  /// Tools path.
  /// </summary>
  [InteropEnumValue("wdToolsPath")]
  ToolsPath = 6,
  /// <summary>
  /// Tutorial path.
  /// </summary>
  [InteropEnumValue("wdTutorialPath")]
  TutorialPath = 7,
  /// <summary>
  /// Startup path.
  /// </summary>
  [InteropEnumValue("wdStartupPath")]
  StartupPath = 8,
  /// <summary>
  /// Program path.
  /// </summary>
  [InteropEnumValue("wdProgramPath")]
  ProgramPath = 9,
  /// <summary>
  /// Graphics filters path.
  /// </summary>
  [InteropEnumValue("wdGraphicsFiltersPath")]
  GraphicsFiltersPath = 10,
  /// <summary>
  /// Text converters path.
  /// </summary>
  [InteropEnumValue("wdTextConvertersPath")]
  TextConvertersPath = 11,
  /// <summary>
  /// Proofing tools path.
  /// </summary>
  [InteropEnumValue("wdProofingToolsPath")]
  ProofingToolsPath = 12,
  /// <summary>
  /// Temp file path.
  /// </summary>
  [InteropEnumValue("wdTempFilePath")]
  TempFilePath = 13,
  /// <summary>
  /// Current folder path.
  /// </summary>
  [InteropEnumValue("wdCurrentFolderPath")]
  CurrentFolderPath = 14,
  /// <summary>
  /// Style Gallery path.
  /// </summary>
  [InteropEnumValue("wdStyleGalleryPath")]
  StyleGalleryPath = 15,
  /// <summary>
  /// Border art path.
  /// </summary>
  [InteropEnumValue("wdBorderArtPath")]
  BorderArtPath = 19
}

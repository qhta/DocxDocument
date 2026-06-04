namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies a default folder for files related to Microsoft Word.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wddefaultfilepath?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType("WdDefaultFilePath")]
public enum DefaultFilePath
{
  /// <summary>
  /// Documents path.
  /// </summary>
  [WordInteropEnumValue("wdDocumentsPath")]
  DocumentsPath = 0,
  /// <summary>
  /// Pictures path.
  /// </summary>
  [WordInteropEnumValue("wdPicturesPath")]
  PicturesPath = 1,
  /// <summary>
  /// User templates path.
  /// </summary>
  [WordInteropEnumValue("wdUserTemplatesPath")]
  UserTemplatesPath = 2,
  /// <summary>
  /// Workgroup templates path.
  /// </summary>
  [WordInteropEnumValue("wdWorkgroupTemplatesPath")]
  WorkgroupTemplatesPath = 3,
  /// <summary>
  /// User Options path.
  /// </summary>
  [WordInteropEnumValue("wdUserOptionsPath")]
  UserOptionsPath = 4,
  /// <summary>
  /// Path for Auto Recover files.
  /// </summary>
  [WordInteropEnumValue("wdAutoRecoverPath")]
  AutoRecoverPath = 5,
  /// <summary>
  /// Tools path.
  /// </summary>
  [WordInteropEnumValue("wdToolsPath")]
  ToolsPath = 6,
  /// <summary>
  /// Tutorial path.
  /// </summary>
  [WordInteropEnumValue("wdTutorialPath")]
  TutorialPath = 7,
  /// <summary>
  /// Startup path.
  /// </summary>
  [WordInteropEnumValue("wdStartupPath")]
  StartupPath = 8,
  /// <summary>
  /// Program path.
  /// </summary>
  [WordInteropEnumValue("wdProgramPath")]
  ProgramPath = 9,
  /// <summary>
  /// Graphics filters path.
  /// </summary>
  [WordInteropEnumValue("wdGraphicsFiltersPath")]
  GraphicsFiltersPath = 10,
  /// <summary>
  /// Text converters path.
  /// </summary>
  [WordInteropEnumValue("wdTextConvertersPath")]
  TextConvertersPath = 11,
  /// <summary>
  /// Proofing tools path.
  /// </summary>
  [WordInteropEnumValue("wdProofingToolsPath")]
  ProofingToolsPath = 12,
  /// <summary>
  /// Temp file path.
  /// </summary>
  [WordInteropEnumValue("wdTempFilePath")]
  TempFilePath = 13,
  /// <summary>
  /// Current folder path.
  /// </summary>
  [WordInteropEnumValue("wdCurrentFolderPath")]
  CurrentFolderPath = 14,
  /// <summary>
  /// Style Gallery path.
  /// </summary>
  [WordInteropEnumValue("wdStyleGalleryPath")]
  StyleGalleryPath = 15,
  /// <summary>
  /// Border art path.
  /// </summary>
  [WordInteropEnumValue("wdBorderArtPath")]
  BorderArtPath = 19
}

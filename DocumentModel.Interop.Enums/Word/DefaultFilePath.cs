namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies a default folder for files related to Microsoft Word.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wddefaultfilepath?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType(typeof(Microsoft.Office.Interop.Word.WdDefaultFilePath))]
public enum DefaultFilePath
{
  /// <summary>
  /// Documents path.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdDefaultFilePath.wdDocumentsPath))]
  DocumentsPath = 0,
  /// <summary>
  /// Pictures path.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdDefaultFilePath.wdPicturesPath))]
  PicturesPath = 1,
  /// <summary>
  /// User templates path.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdDefaultFilePath.wdUserTemplatesPath))]
  UserTemplatesPath = 2,
  /// <summary>
  /// Workgroup templates path.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdDefaultFilePath.wdWorkgroupTemplatesPath))]
  WorkgroupTemplatesPath = 3,
  /// <summary>
  /// User Options path.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdDefaultFilePath.wdUserOptionsPath))]
  UserOptionsPath = 4,
  /// <summary>
  /// Path for Auto Recover files.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdDefaultFilePath.wdAutoRecoverPath))]
  AutoRecoverPath = 5,
  /// <summary>
  /// Tools path.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdDefaultFilePath.wdToolsPath))]
  ToolsPath = 6,
  /// <summary>
  /// Tutorial path.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdDefaultFilePath.wdTutorialPath))]
  TutorialPath = 7,
  /// <summary>
  /// Startup path.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdDefaultFilePath.wdStartupPath))]
  StartupPath = 8,
  /// <summary>
  /// Program path.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdDefaultFilePath.wdProgramPath))]
  ProgramPath = 9,
  /// <summary>
  /// Graphics filters path.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdDefaultFilePath.wdGraphicsFiltersPath))]
  GraphicsFiltersPath = 10,
  /// <summary>
  /// Text converters path.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdDefaultFilePath.wdTextConvertersPath))]
  TextConvertersPath = 11,
  /// <summary>
  /// Proofing tools path.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdDefaultFilePath.wdProofingToolsPath))]
  ProofingToolsPath = 12,
  /// <summary>
  /// Temp file path.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdDefaultFilePath.wdTempFilePath))]
  TempFilePath = 13,
  /// <summary>
  /// Current folder path.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdDefaultFilePath.wdCurrentFolderPath))]
  CurrentFolderPath = 14,
  /// <summary>
  /// Style Gallery path.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdDefaultFilePath.wdStyleGalleryPath))]
  StyleGalleryPath = 15,
  /// <summary>
  /// Border art path.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdDefaultFilePath.wdBorderArtPath))]
  BorderArtPath = 19
}

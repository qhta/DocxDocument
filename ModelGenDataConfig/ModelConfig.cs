using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;

using Qhta.Collections;
using Qhta.TextUtils;

namespace ModelGenDataConfig;

public class ModelConfig
{

  private ModelConfig(){ }

  public static ModelConfig Instance
  {
    get
    {
      if (_Instance == null)
        _Instance = new ModelConfig();
      return _Instance;
    }
  }
  private static ModelConfig _Instance = null!;

  #region Namespaces

  /// <summary>
  /// List of DocumentFormat namespaces that should be included in processing.
  /// </summary>
  public WildcardStrings IncludedNamespaces { get; } = new WildcardStrings
  {
  };

  /// <summary>
  /// List of DocumentFormat namespaces that should be excluded from processing.
  /// </summary>
  public WildcardStrings ExcludedNamespaces { get; } = new WildcardStrings
  {
    "DocumentFormat.OpenXml",
    "*Metadata", "*Features", "*Framework", "*Framework.Schema", "*Validation", "*Validation.Schema",
    "*Presentation*",
    "*Spreadsheet*",
    "*Excel*",
    "*PowerPoint*",
    "*.Office.Word",
    "*.VariantTypes",
    "DocumentFormat.OpenXml.Vml.Presentation",
    "DocumentFormat.OpenXml.Vml.Spreadsheet",
  };

  /// <summary>
  /// Translation table of DocumentFormat namespaces to DocumentModel namespaces.
  /// </summary>
  public BiDiDictionary<string, string> TranslatedNamespaces { get; } = new BiDiDictionary<string, string>()
  {
    {"DocumentFormat.OpenXml", "DocumentModel" },
    {"DocumentFormat.OpenXml.AdditionalCharacteristics", "DocumentModel" },
    {"DocumentFormat.OpenXml.Bibliography", "DocumentModel.Bibliography" },
    {"DocumentFormat.OpenXml.CustomProperties", "DocumentModel.Properties" },
    {"DocumentFormat.OpenXml.CustomXmlDataProperties", "DocumentModel.CustomXml" },
    {"DocumentFormat.OpenXml.CustomXmlSchemaReferences", "DocumentModel.CustomXml" },
    {"DocumentFormat.OpenXml.Drawing", "DocumentModel.Drawings" },
    {"DocumentFormat.OpenXml.Drawing.ChartDrawing", "DocumentModel.Drawings.ChartDrawing" },
    {"DocumentFormat.OpenXml.Drawing.Charts", "DocumentModel.Drawings.Charts" },
    {"DocumentFormat.OpenXml.Drawing.Diagrams", "DocumentModel.Drawings.Diagrams" },
    {"DocumentFormat.OpenXml.Drawing.LegacyCompatibility", "DocumentModel.Drawings.Legacy" },
    {"DocumentFormat.OpenXml.Drawing.LockedCanvas", "DocumentModel.Drawings.LockedCanvas" },
    {"DocumentFormat.OpenXml.Drawing.Pictures", "DocumentModel.Drawings.Pictures" },
    {"DocumentFormat.OpenXml.Drawing.Spreadsheet", "DocumentModel.Drawings.Spreadsheet" },
    {"DocumentFormat.OpenXml.Drawing.Wordprocessing", "DocumentModel.Drawings.Wordprocessing" },
    {"DocumentFormat.OpenXml.EMMA", "DocumentModel.EMMA" },
    {"DocumentFormat.OpenXml.ExtendedProperties", "DocumentModel.Properties" },
    {"DocumentFormat.OpenXml.Features", "DocumentModel.Framework" },
    {"DocumentFormat.OpenXml.Framework", "DocumentModel.Framework" },
    {"DocumentFormat.OpenXml.Framework.Metadata", "DocumentModel.Framework" },
    {"DocumentFormat.OpenXml.Framework.Schema", "DocumentModel.Framework" },
    {"DocumentFormat.OpenXml.InkML", "DocumentModel.Painting" },
    {"DocumentFormat.OpenXml.Math", "DocumentModel.Math" },
    {"DocumentFormat.OpenXml.Office.ActiveX", "DocumentModel.UI" },
    {"DocumentFormat.OpenXml.Office.ContentType", "DocumentModel.UI" },
    {"DocumentFormat.OpenXml.Office.CoverPageProps", "DocumentModel.UI" },
    {"DocumentFormat.OpenXml.Office.CustomDocumentInformationPanel", "DocumentModel.UI" },
    {"DocumentFormat.OpenXml.Office.CustomUI", "DocumentModel.UI" },
    {"DocumentFormat.OpenXml.Office.CustomXsn", "DocumentModel.UI" },
    {"DocumentFormat.OpenXml.Office.Drawing", "DocumentModel.Drawings.Office" },
    {"DocumentFormat.OpenXml.Office.Drawing.Y2021.OEmbed", "DocumentModel.Drawings.Office.OEmbed" },
    {"DocumentFormat.OpenXml.Office.Drawing.Y2021.ScriptLink", "DocumentModel.Drawings.Office.ScriptLink" },
    {"DocumentFormat.OpenXml.Office.Excel", "DocumentModel.Spreadsheet" },
    {"DocumentFormat.OpenXml.Office.LongProperties", "DocumentModel" },
    {"DocumentFormat.OpenXml.Office.MetaAttributes", "DocumentModel" },
    {"DocumentFormat.OpenXml.Office.PowerPoint.Y2021.M06.Main", "DocumentModel.Presentation" },
    {"DocumentFormat.OpenXml.Office.SpreadSheetML.Y2021.ExtLinks2021", "DocumentModel.Spreadsheet" },
    {"DocumentFormat.OpenXml.Office.SpreadSheetML.Y2022.PivotVersionInfo", "DocumentModel.Spreadsheet" },
    {"DocumentFormat.OpenXml.Office.Word", "DocumentModel.Wordprocessing" },
    {"DocumentFormat.OpenXml.Office.Word.Y2020.OEmbed", "DocumentModel.Wordprocessing.OEmbed" },
    {"DocumentFormat.OpenXml.Office2010.CustomUI", "DocumentModel" },
    {"DocumentFormat.OpenXml.Office2010.Drawing", "DocumentModel.Drawings" },
    {"DocumentFormat.OpenXml.Office2010.Drawing.ChartDrawing", "DocumentModel.Drawings.ChartDrawings" },
    {"DocumentFormat.OpenXml.Office2010.Drawing.Charts", "DocumentModel.Drawings.Charts" },
    {"DocumentFormat.OpenXml.Office2010.Drawing.Diagram", "DocumentModel.Drawings.Diagrams" },
    {"DocumentFormat.OpenXml.Office2010.Drawing.LegacyCompatibility", "DocumentModel.Drawings.Legacy" },
    {"DocumentFormat.OpenXml.Office2010.Drawing.Pictures", "DocumentModel.Drawings.Pictures" },
    {"DocumentFormat.OpenXml.Office2010.Drawing.Slicer", "DocumentModel.Drawings.Slicer" },
    {"DocumentFormat.OpenXml.Office2010.Excel", "DocumentModel.Spreadsheet" },
    {"DocumentFormat.OpenXml.Office2010.Excel.Drawing", "DocumentModel.Drawings.Spreadsheet" },
    {"DocumentFormat.OpenXml.Office2010.ExcelAc", "DocumentModel.Spreadsheet" },
    {"DocumentFormat.OpenXml.Office2010.Ink", "DocumentModel" },
    {"DocumentFormat.OpenXml.Office2010.PowerPoint", "DocumentModel.Presentation" },
    {"DocumentFormat.OpenXml.Office2010.Word", "DocumentModel.Wordprocessing" },
    {"DocumentFormat.OpenXml.Office2010.Word.Drawing", "DocumentModel.Wordprocessing.Drawings" },
    {"DocumentFormat.OpenXml.Office2010.Word.DrawingCanvas", "DocumentModel.Wordprocessing.DrawingCanvas" },
    {"DocumentFormat.OpenXml.Office2010.Word.DrawingGroup", "DocumentModel.Wordprocessing.DrawingGroup" },
    {"DocumentFormat.OpenXml.Office2010.Word.DrawingShape", "DocumentModel.Wordprocessing.DrawingShape" },
    {"DocumentFormat.OpenXml.Office2013.Drawing", "DocumentModel.Drawings" },
    {"DocumentFormat.OpenXml.Office2013.Drawing.Chart", "DocumentModel.Drawings.Charts" },
    {"DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle", "DocumentModel.Drawings.ChartsStyle" },
    {"DocumentFormat.OpenXml.Office2013.Drawing.TimeSlicer", "DocumentModel.Drawings" },
    {"DocumentFormat.OpenXml.Office2013.Excel", "DocumentModel.Spreadsheet" },
    {"DocumentFormat.OpenXml.Office2013.ExcelAc", "DocumentModel.Spreadsheet" },
    {"DocumentFormat.OpenXml.Office2013.PowerPoint", "DocumentModel.Presentation" },
    {"DocumentFormat.OpenXml.Office2013.PowerPoint.Roaming", "DocumentModel.Presentation" },
    {"DocumentFormat.OpenXml.Office2013.Theme", "DocumentModel" },
    {"DocumentFormat.OpenXml.Office2013.WebExtension", "DocumentModel.WebExtensions" },
    {"DocumentFormat.OpenXml.Office2013.WebExtentionPane", "DocumentModel.WebExtensions.UI" },
    {"DocumentFormat.OpenXml.Office2013.Word", "DocumentModel.Wordprocessing" },
    {"DocumentFormat.OpenXml.Office2013.Word.Drawing", "DocumentModel.Drawings.Wordprocessing" },
    {"DocumentFormat.OpenXml.Office2016.Drawing", "DocumentModel.Drawings" },
    {"DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing", "DocumentModel.Drawings.ChartDrawings" },
    {"DocumentFormat.OpenXml.Office2016.Drawing.Charts", "DocumentModel.Drawings.Charts" },
    {"DocumentFormat.OpenXml.Office2016.Drawing.ChartsAc", "DocumentModel.Drawings.Charts" },
    {"DocumentFormat.OpenXml.Office2016.Drawing.Command", "DocumentModel.Drawings" },
    {"DocumentFormat.OpenXml.Office2016.Excel", "DocumentModel.Spreadsheet" },
    {"DocumentFormat.OpenXml.Office2016.ExcelAc", "DocumentModel.Spreadsheet" },
    {"DocumentFormat.OpenXml.Office2016.Presentation", "DocumentModel.Presentation" },
    {"DocumentFormat.OpenXml.Office2016.Presentation.Command", "DocumentModel.Presentation" },
    {"DocumentFormat.OpenXml.Office2016.Word.Symex", "DocumentModel.Wordprocessing" },
    {"DocumentFormat.OpenXml.Office2019.Drawing", "DocumentModel.Drawings" },
    {"DocumentFormat.OpenXml.Office2019.Drawing.Animation", "DocumentModel.Drawings.Animation" },
    {"DocumentFormat.OpenXml.Office2019.Drawing.Animation.Model3D", "DocumentModel.Drawings.Animation.Model3D" },
    {"DocumentFormat.OpenXml.Office2019.Drawing.Chart", "DocumentModel.Drawings.Charts" },
    {"DocumentFormat.OpenXml.Office2019.Drawing.Diagram11", "DocumentModel.Drawings.Diagram1" },
    {"DocumentFormat.OpenXml.Office2019.Drawing.Diagram12", "DocumentModel.Drawings.Diagram2" },
    {"DocumentFormat.OpenXml.Office2019.Drawing.HyperLinkColor", "DocumentModel.Drawings" },
    {"DocumentFormat.OpenXml.Office2019.Drawing.Ink", "DocumentModel.Drawings" },
    {"DocumentFormat.OpenXml.Office2019.Drawing.Model3D", "DocumentModel.Drawings.Model3D" },
    {"DocumentFormat.OpenXml.Office2019.Drawing.SVG", "DocumentModel.Drawings.SVG" },
    {"DocumentFormat.OpenXml.Office2019.Excel.CalcFeatures", "DocumentModel.Spreadsheet" },
    {"DocumentFormat.OpenXml.Office2019.Excel.DynamicArray", "DocumentModel.Spreadsheet" },
    {"DocumentFormat.OpenXml.Office2019.Excel.PivotDefaultLayout", "DocumentModel.Spreadsheet" },
    {"DocumentFormat.OpenXml.Office2019.Excel.RichData", "DocumentModel.Spreadsheet" },
    {"DocumentFormat.OpenXml.Office2019.Excel.RichData2", "DocumentModel.Spreadsheet" },
    {"DocumentFormat.OpenXml.Office2019.Excel.ThreadedComments", "DocumentModel.Spreadsheet" },
    {"DocumentFormat.OpenXml.Office2019.Presentation", "DocumentModel.Presentation" },
    {"DocumentFormat.OpenXml.Office2019.Word.Cid", "DocumentModel.Wordprocessing" },
    {"DocumentFormat.OpenXml.Office2021.DocumentTasks", "DocumentModel" },
    {"DocumentFormat.OpenXml.Office2021.Drawing.DocumentClassification", "DocumentModel.Drawings" },
    {"DocumentFormat.OpenXml.Office2021.Drawing.Livefeed", "DocumentModel.Drawings" },
    {"DocumentFormat.OpenXml.Office2021.Drawing.SketchyShapes", "DocumentModel.Drawings" },
    {"DocumentFormat.OpenXml.Office2021.Excel.ExternalLinks", "DocumentModel.Spreadsheet" },
    {"DocumentFormat.OpenXml.Office2021.Excel.NamedSheetViews", "DocumentModel.Spreadsheet" },
    {"DocumentFormat.OpenXml.Office2021.Excel.Pivot", "DocumentModel.Spreadsheet" },
    {"DocumentFormat.OpenXml.Office2021.Excel.RichDataWebImage", "DocumentModel.Spreadsheet" },
    {"DocumentFormat.OpenXml.Office2021.Excel.RichValueRefreshIntervals", "DocumentModel.Spreadsheet" },
    {"DocumentFormat.OpenXml.Office2021.Excel.ThreadedComments2", "DocumentModel.Spreadsheet" },
    {"DocumentFormat.OpenXml.Office2021.MipLabelMetaData", "DocumentModel" },
    {"DocumentFormat.OpenXml.Office2021.OfficeExtLst", "DocumentModel" },
    {"DocumentFormat.OpenXml.Office2021.PowerPoint.Comment", "DocumentModel.Presentation" },
    {"DocumentFormat.OpenXml.Office2021.PowerPoint.Designer", "DocumentModel.Presentation" },
    {"DocumentFormat.OpenXml.Office2021.PowerPoint.Tasks", "DocumentModel.Presentation" },
    {"DocumentFormat.OpenXml.Office2021.Word.CommentsExt", "DocumentModel.Wordprocessing" },
    {"DocumentFormat.OpenXml.Office2021.Word.ExtensionList", "DocumentModel.Wordprocessing" },
    {"DocumentFormat.OpenXml.Office.Drawing.Y2022.ImageFormula", "DocumentModel.Drawings" },
    {"DocumentFormat.OpenXml.Packaging", "DocumentModel.Packaging" },
    {"DocumentFormat.OpenXml.Presentation", "DocumentModel.Presentation" },
    {"DocumentFormat.OpenXml.Spreadsheet", "DocumentModel.Spreadsheet" },
    {"DocumentFormat.OpenXml.Validation", "DocumentModel.Validation" },
    {"DocumentFormat.OpenXml.Validation.Schema", "DocumentModel.Validation" },
    {"DocumentFormat.OpenXml.Validation.Schema.Restrictions", "DocumentModel.Validation" },
    {"DocumentFormat.OpenXml.Validation.Semantic", "DocumentModel.Validation" },
    {"DocumentFormat.OpenXml.VariantTypes", "DocumentModel.VariantTypes" },
    {"DocumentFormat.OpenXml.Vml", "DocumentModel.Vml" },
    {"DocumentFormat.OpenXml.Vml.Office", "DocumentModel.Vml" },
    {"DocumentFormat.OpenXml.Vml.Presentation", "DocumentModel.Presentation.Vml" },
    {"DocumentFormat.OpenXml.Vml.Spreadsheet", "DocumentModel.Spreadsheet.Vml" },
    {"DocumentFormat.OpenXml.Vml.Wordprocessing", "DocumentModel.Wordprocessing.Vml" },
    {"DocumentFormat.OpenXml.Wordprocessing", "DocumentModel.Wordprocessing" },
  };

  /// <summary>
  /// Documentation headings to namespaces conversion table.
  /// </summary>
  public Dictionary<string, string> Headings2Namespaces = new Dictionary<string, string>()
    {
      { "WordprocessingML Reference Material", "DocumentFormat.OpenXml.Wordprocessing" },
      { "DrawingML - Main", "DocumentFormat.OpenXml.Drawing" },
      { "DrawingML - Picture", "DocumentFormat.OpenXml.Drawing.Pictures" },
      { "DrawingML - Locked Canvas", "DocumentFormat.OpenXml.Drawing.LockedCanvas" },
      { "DrawingML - WordprocessingML Drawing", "DocumentFormat.OpenXml.Drawing.Wordprocessing" },
      { "DrawingML - SpreadsheetML Drawing", "DocumentFormat.OpenXml.Drawing.Spreadsheet" },
      { "DrawingML - Charts", "DocumentFormat.OpenXml.Drawing.Charts" },
      { "DrawingML - Chart Drawings", "DocumentFormat.OpenXml.Drawing.ChartDrawing" },
      { "DrawingML - Diagrams", "DocumentFormat.OpenXml.Drawing.Diagrams" },
      { "Math", "DocumentFormat.OpenXml.Math" },
      { "Extended Properties", "DocumentFormat.OpenXml.ExtendedProperties" },
      { "Custom Properties", "DocumentFormat.OpenXml.CustomProperties" },
      { "Variant Types", "DocumentFormat.OpenXml.VariantTypes" },
      { "Custom XML Data Properties", "DocumentFormat.OpenXml.CustomXmlDataProperties" },
      { "Bibliography", "DocumentFormat.OpenXml.Bibliography" },
      { "Additional Characteristics", "DocumentFormat.OpenXml.AdditionalCharacteristics" },
    };

  /// <summary>
  /// Shortcuts for DocumentFormat.OpenXml namespaces. 
  /// Shortcuts for DocumentModel namespaces can be translated by replacing starting "DX" with "DM".
  /// Shortcuts for DocumentModel.OpenXml namespaces can be translated by replacing starting "DX" with "DXM".
  /// It is implemented in <see cref="NamespaceShortcut(string)"/> function.
  /// </summary>
  public BiDiDictionary<string, string> NamespaceShortcuts { get; } = new BiDiDictionary<string, string>()
  {
    { "DocumentFormat.OpenXml", "DX" },
    { "DocumentFormat.OpenXml.AdditionalCharacteristics", "DXAddCht" },
    { "DocumentFormat.OpenXml.Bibliography", "DXBib" },
    { "DocumentFormat.OpenXml.CustomProperties", "DXCustProps" },
    { "DocumentFormat.OpenXml.CustomXmlDataProperties", "DXCustXmlDataProps" },
    { "DocumentFormat.OpenXml.CustomXmlSchemaReferences", "DXCustXmlSchRefs" },
    { "DocumentFormat.OpenXml.Drawing", "DXDraw" },
    { "DocumentFormat.OpenXml.Drawing.ChartDrawing", "DXDrawChartDraw" },
    { "DocumentFormat.OpenXml.Drawing.Charts", "DXDrawCharts" },
    { "DocumentFormat.OpenXml.Drawing.Diagrams", "DXDrawDgms" },
    { "DocumentFormat.OpenXml.Drawing.LegacyCompatibility", "DXDrawLegComp" },
    { "DocumentFormat.OpenXml.Drawing.LockedCanvas", "DXDrawLockCanv" },
    { "DocumentFormat.OpenXml.Drawing.Pictures", "DXDrawPict" },
    { "DocumentFormat.OpenXml.Drawing.Spreadsheet", "DXDrawS" },
    { "DocumentFormat.OpenXml.Drawing.Wordprocessing", "DXDrawW" },
    { "DocumentFormat.OpenXml.EMMA", "DXEMMA" },
    { "DocumentFormat.OpenXml.ExtendedProperties", "DXExtProps" },
    { "DocumentFormat.OpenXml.Features", "DXFeat" },
    { "DocumentFormat.OpenXml.Framework", "DXFwork" },
    { "DocumentFormat.OpenXml.Framework.Metadata", "DXFworkMeta" },
    { "DocumentFormat.OpenXml.Framework.Schema", "DXFworkSch" },
    { "DocumentFormat.OpenXml.InkML", "DXInkML" },
    { "DocumentFormat.OpenXml.Math", "DXM" },
    { "DocumentFormat.OpenXml.Office.ActiveX", "DXOActiveX" },
    { "DocumentFormat.OpenXml.Office.ContentType", "DXOContentType" },
    { "DocumentFormat.OpenXml.Office.CoverPageProps", "DXOCoverPageProps" },
    { "DocumentFormat.OpenXml.Office.CustomDocumentInformationPanel", "DXOCustDocInfPnl" },
    { "DocumentFormat.OpenXml.Office.CustomUI", "DXOCustUI" },
    { "DocumentFormat.OpenXml.Office.CustomXsn", "DXOCustXsn" },
    { "DocumentFormat.OpenXml.Office.Drawing", "DXODraw" },
    { "DocumentFormat.OpenXml.Office.Drawing.Y2021.OEmbed", "DXODrawY21OEmb" },
    { "DocumentFormat.OpenXml.Office.Drawing.Y2021.ScriptLink", "DXODrawY21ScptLnk" },
    { "DocumentFormat.OpenXml.Office.Excel", "DXOS" },
    { "DocumentFormat.OpenXml.Office.LongProperties", "DXOLongProps" },
    { "DocumentFormat.OpenXml.Office.MetaAttributes", "DXOMetaAttr" },
    { "DocumentFormat.OpenXml.Office.PowerPoint.Y2021.M06.Main", "DXOPY21M06Main" },
    { "DocumentFormat.OpenXml.Office.SpreadSheetML.Y2021.ExtLinks2021", "DXOSMLY21ExtLnks2021" },
    { "DocumentFormat.OpenXml.Office.SpreadSheetML.Y2022.PivotVersionInfo", "DXOSMLY22PivotVerInf" },
    { "DocumentFormat.OpenXml.Office.Word", "DXOW" },
    { "DocumentFormat.OpenXml.Office.Word.Y2020.OEmbed", "DXOWY20OEmb" },
    { "DocumentFormat.OpenXml.Office2010.CustomUI", "DXO10CustUI" },
    { "DocumentFormat.OpenXml.Office2010.Drawing", "DXO10Draw" },
    { "DocumentFormat.OpenXml.Office2010.Drawing.ChartDrawing", "DXO10DrawChartDraw" },
    { "DocumentFormat.OpenXml.Office2010.Drawing.Charts", "DXO10DrawCharts" },
    { "DocumentFormat.OpenXml.Office2010.Drawing.Diagram", "DXO10DrawDgm" },
    { "DocumentFormat.OpenXml.Office2010.Drawing.LegacyCompatibility", "DXO10DrawLegComp" },
    { "DocumentFormat.OpenXml.Office2010.Drawing.Pictures", "DXO10DrawPict" },
    { "DocumentFormat.OpenXml.Office2010.Drawing.Slicer", "DXO10DrawSlicer" },
    { "DocumentFormat.OpenXml.Office.Drawing.Y2022.ImageFormula", "DXODrawY22IF" },
    { "DocumentFormat.OpenXml.Office2010.Excel", "DXO10S" },
    { "DocumentFormat.OpenXml.Office2010.Excel.Drawing", "DXO10SDraw" },
    { "DocumentFormat.OpenXml.Office2010.ExcelAc", "DXO10SAc" },
    { "DocumentFormat.OpenXml.Office2010.Ink", "DXO10Ink" },
    { "DocumentFormat.OpenXml.Office2010.PowerPoint", "DXO10P" },
    { "DocumentFormat.OpenXml.Office2010.Word", "DXO10W" },
    { "DocumentFormat.OpenXml.Office2010.Word.Drawing", "DXO10WDraw" },
    { "DocumentFormat.OpenXml.Office2010.Word.DrawingCanvas", "DXO10WDrawCnv" },
    { "DocumentFormat.OpenXml.Office2010.Word.DrawingGroup", "DXO10WDrawGroup" },
    { "DocumentFormat.OpenXml.Office2010.Word.DrawingShape", "DXO10WDrawShp" },
    { "DocumentFormat.OpenXml.Office2013.Drawing", "DXO13Draw" },
    { "DocumentFormat.OpenXml.Office2013.Drawing.Chart", "DXO13DrawChart" },
    { "DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle", "DXO13DrawChartStyle" },
    { "DocumentFormat.OpenXml.Office2013.Drawing.TimeSlicer", "DXO13DrawTimeSlicer" },
    { "DocumentFormat.OpenXml.Office2013.Excel", "DXO13S" },
    { "DocumentFormat.OpenXml.Office2013.ExcelAc", "DXO13SAc" },
    { "DocumentFormat.OpenXml.Office2013.PowerPoint", "DXO13P" },
    { "DocumentFormat.OpenXml.Office2013.PowerPoint.Roaming", "DXO13PRoaming" },
    { "DocumentFormat.OpenXml.Office2013.Theme", "DXO13Theme" },
    { "DocumentFormat.OpenXml.Office2013.WebExtension", "DXO13WebExt" },
    { "DocumentFormat.OpenXml.Office2013.WebExtentionPane", "DXO13WebExtPane" },
    { "DocumentFormat.OpenXml.Office2013.Word", "DXO13W" },
    { "DocumentFormat.OpenXml.Office2013.Word.Drawing", "DXO13WDraw" },
    { "DocumentFormat.OpenXml.Office2016.Drawing", "DXO16Draw" },
    { "DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing", "DXO16DrawChartDraw" },
    { "DocumentFormat.OpenXml.Office2016.Drawing.Charts", "DXO16DrawCharts" },
    { "DocumentFormat.OpenXml.Office2016.Drawing.ChartsAc", "DXO16DrawChartsAc" },
    { "DocumentFormat.OpenXml.Office2016.Drawing.Command", "DXO16DrawCmd" },
    { "DocumentFormat.OpenXml.Office2016.Excel", "DXO16S" },
    { "DocumentFormat.OpenXml.Office2016.ExcelAc", "DXO16SAc" },
    { "DocumentFormat.OpenXml.Office2016.Presentation", "DXO16P" },
    { "DocumentFormat.OpenXml.Office2016.Presentation.Command", "DXO16PCmd" },
    { "DocumentFormat.OpenXml.Office2016.Word.Symex", "DXO16WSymex" },
    { "DocumentFormat.OpenXml.Office2019.Drawing", "DXO19Draw" },
    { "DocumentFormat.OpenXml.Office2019.Drawing.Animation", "DXO19DrawAnim" },
    { "DocumentFormat.OpenXml.Office2019.Drawing.Animation.Model3D", "DXO19DrawAnim3D" },
    { "DocumentFormat.OpenXml.Office2019.Drawing.Chart", "DXO19DrawChart" },
    { "DocumentFormat.OpenXml.Office2019.Drawing.Diagram11", "DXO19DrawDgm11" },
    { "DocumentFormat.OpenXml.Office2019.Drawing.Diagram12", "DXO19DrawDgm12" },
    { "DocumentFormat.OpenXml.Office2019.Drawing.HyperLinkColor", "DXO19DrawHLnkClr" },
    { "DocumentFormat.OpenXml.Office2019.Drawing.Ink", "DXO19DrawInk" },
    { "DocumentFormat.OpenXml.Office2019.Drawing.Model3D", "DXO19Draw3D" },
    { "DocumentFormat.OpenXml.Office2019.Drawing.SVG", "DXO19DrawSVG" },
    { "DocumentFormat.OpenXml.Office2019.Excel.CalcFeatures", "DXO19SCalcFeat" },
    { "DocumentFormat.OpenXml.Office2019.Excel.DynamicArray", "DXO19SDynArray" },
    { "DocumentFormat.OpenXml.Office2019.Excel.PivotDefaultLayout", "DXO19SPivotDefLayt" },
    { "DocumentFormat.OpenXml.Office2019.Excel.RichData", "DXO19SRichData" },
    { "DocumentFormat.OpenXml.Office2019.Excel.RichData2", "DXO19SRichData2" },
    { "DocumentFormat.OpenXml.Office2019.Excel.ThreadedComments", "DXO19SThrComt" },
    { "DocumentFormat.OpenXml.Office2019.Presentation", "DXO19P" },
    { "DocumentFormat.OpenXml.Office2019.Word.Cid", "DXO19WCid" },
    { "DocumentFormat.OpenXml.Office2021.DocumentTasks", "DXO21DocTasks" },
    { "DocumentFormat.OpenXml.Office2021.Drawing.DocumentClassification", "DXO21DrawDocCls" },
    { "DocumentFormat.OpenXml.Office2021.Drawing.Livefeed", "DXO21DrawLivefeed" },
    { "DocumentFormat.OpenXml.Office2021.Drawing.SketchyShapes", "DXO21DrawSketchyShps" },
    { "DocumentFormat.OpenXml.Office2021.Excel.ExternalLinks", "DXO21SExtLnks" },
    { "DocumentFormat.OpenXml.Office2021.Excel.NamedSheetViews", "DXO21SNamedSheetVws" },
    { "DocumentFormat.OpenXml.Office2021.Excel.Pivot", "DXO21SPivot" },
    { "DocumentFormat.OpenXml.Office2021.Excel.RichDataWebImage", "DXO21SRichDataWebImg" },
    { "DocumentFormat.OpenXml.Office2021.Excel.RichValueRefreshIntervals", "DXO21SRichValRefshImtv" },
    { "DocumentFormat.OpenXml.Office2021.Excel.ThreadedComments2", "DXO21SThrComt2" },
    { "DocumentFormat.OpenXml.Office2021.MipLabelMetaData", "DXO21MipLabelMeta" },
    { "DocumentFormat.OpenXml.Office2021.OfficeExtLst", "DXO21OExtLst" },
    { "DocumentFormat.OpenXml.Office2021.PowerPoint.Comment", "DXO21PComt" },
    { "DocumentFormat.OpenXml.Office2021.PowerPoint.Designer", "DXO21PDsg" },
    { "DocumentFormat.OpenXml.Office2021.PowerPoint.Tasks", "DXO21PTasks" },
    { "DocumentFormat.OpenXml.Office2021.Word.CommentsExt", "DXO21WComtExt" },
    { "DocumentFormat.OpenXml.Office2021.Word.ExtensionList", "DXO21WExtList" },
    { "DocumentFormat.OpenXml.Packaging", "DXPack" },
    { "DocumentFormat.OpenXml.Presentation", "DXP" },
    { "DocumentFormat.OpenXml.Spreadsheet", "DXS" },
    { "DocumentFormat.OpenXml.Validation", "DXValid" },
    { "DocumentFormat.OpenXml.Validation.Schema", "DXValidSch" },
    { "DocumentFormat.OpenXml.Validation.Schema.Restrictions", "DXValidSchRest" },
    { "DocumentFormat.OpenXml.Validation.Semantic", "DXValidSmt" },
    { "DocumentFormat.OpenXml.VariantTypes", "DXVT" },
    { "DocumentFormat.OpenXml.Vml", "DXVml" },
    { "DocumentFormat.OpenXml.Vml.Office", "DXVmlO" },
    { "DocumentFormat.OpenXml.Vml.Presentation", "DXVmlP" },
    { "DocumentFormat.OpenXml.Vml.Spreadsheet", "DXVmlS" },
    { "DocumentFormat.OpenXml.Vml.Wordprocessing", "DXVmlW" },
    { "DocumentFormat.OpenXml.Wordprocessing", "DXW" },
  };


  public static string NamespaceShortcut(string ns)
  {
    if (ns.StartsWith("System"))
      return string.Empty;
    if (ns.StartsWith("DocumentFormat"))
    {
      if (ModelConfig.Instance.NamespaceShortcuts.TryGetValue2(ns, out var shortcut))
        return shortcut;
    }
    else
    if (ns.StartsWith("DocumentModel.OpenXml"))
    {
      ns = ns.ReplaceStart("DocumentModel", "DocumentFormat");
      if (ModelConfig.Instance.NamespaceShortcuts.TryGetValue2(ns, out var shortcut))
      {
        shortcut.ReplaceStart("DX", "DXM");
        return shortcut;
      }
    }
    else
    if (ns.StartsWith("DocumentModel"))
    {
      ns = ns.ReplaceStart("DocumentModel", "DocumentFormat.OpenXml");
      if (ModelConfig.Instance.NamespaceShortcuts.TryGetValue2(ns, out var shortcut))
      {
        shortcut.ReplaceStart("DX", "DM");
        return shortcut;
      }
    }
    return ns;
  }
  #endregion

  #region Properties

  public WildcardStrings ExcludedProperties { get; } = new WildcardStrings
  {
    "FirstChild", "LastChild", "HasChildren", "InnerText", "InnerXml", "Features",
    "OpenXmlElementContext", "HasAttributes", "ExtendedAttributes", "ChildElements",
    "Parent", "NamespaceUri", "LocalName", "Prefix", "NamespaceDeclarations",
    "XmlQualifiedName", "XName", "OuterXml", "MCAttributes",
    //"RootElement", 
    "IsRootElementLoaded",
    "RelationshipErrorHandlerFactory",
    "AddError",
    "*Part",
    "HasValue",
    "OpenXmlPackage",
    "Container",
    "RootElementContext",
    "WebExtensions"

  };

  public Dictionary<string, string> PropertyTranslateTable = new()
  {
    { "DXW.LatentStyles.Count", "TotalCount" },
    { "DXW.LatentStyles.LatentStyleExceptionInfos", "Items" },
    //{ "DXW.LatentStyle.Default", "IsDefault" },
    { "DXW.Style.Default", "IsDefault" },
    { "DXW.Style.CustomStyle", "IsCustom" },
    { "DXW.Style.AutoRedefine", "IsAutoRedefined" },
    { "DXW.Style.StyleHidden", "IsHidden" },
    { "DXW.Style.SemiHidden", "IsSemiHidden" },
    { "DXW.Style.UnhideWhenUsed", "IsUnhiddenWhenUsed" },
    { "DXW.Style.PrimaryStyle", "IsPrimary" },
    { "DXW.Style.Locked", "IsLocked" },
    { "DXW.Style.Personal", "IsPersonal" },
    { "DXW.Style.PersonalCompose", "IsPersonalCompose" },
    { "DXW.Style.PersonalReply", "IsPersonalReply" },
    { "DXW.Font.Panose1Number", "Panose"},
    };

  public Dictionary<string, string> PropertyTypeConversion { get; } = new()
  {
    { "DocumentModel.DocumentSettings.DocumentId", "HexInt" },
    { "DocumentModel.DocumentSettings.PersistentDocumentId", "Guid" },
    { "DocumentModel.Wordprocessing.CheckBoxSymbolType.Val", "HexChar" },
    { "DocumentModel.Wordprocessing.Mcd.BEncrypt", "HexChar" },
    { "DocumentModel.Wordprocessing.Mcd.Cmg", "HexChar" },
    { "*.Rsid", "HexInt" },
    { "DocumentModel.Wordprocessing.Rsids.RsidRoot", "HexInt" },
    { "DocumentModel.Wordprocessing.Rsids.Items", "Collection<HexInt>" },
  };

  public Dictionary<string, Type> PropertyTypes { get; } = new()
  {
    //{ "DocumentModel.DocumentSettings.DocumentId", typeof(HexInt) },
    //{ "DocumentModel.DocumentSettings.PersistentDocumentId", typeof(Guid) },
    //{ "DocumentModel.Wordprocessing.CheckBoxSymbolType.Val", typeof(HexChar) },
    //{ "DocumentModel.Wordprocessing.Mcd.BEncrypt", typeof(HexChar) },
    //{ "DocumentModel.Wordprocessing.Mcd.Cmg", typeof(HexChar) },
    //{ "*.Rsid", typeof(HexInt) },
    //{ "DocumentModel.Wordprocessing.Rsids.RsidRoot", typeof(HexInt) },
    //{ "DocumentModel.Wordprocessing.Rsids.Items", typeof(Collection<HexInt>) },
  };

  public void BuildPropertyTypesDictionary()
  {
    foreach (var item in PropertyTypeConversion)
    {
      if (item.Value.StartsWith("Collection<"))
      {
        var k = "Collection<".Length;
        var str = item.Value.Substring(k, item.Value.Length-k-1);
        var type = Type.GetType(str);
        Debug.Assert(type!=null);
        type = typeof(Collection<>).MakeGenericType(type);
        PropertyTypes.Add(item.Key, type);
      }
      else
      {
        var type = Type.GetType(item.Value);
        Debug.Assert(type!=null);
        if (type!=null)
          PropertyTypes.Add(item.Key, type);
      }
    }
  }

  public bool TryGetPropertyType(string propertyName, [MaybeNullWhen(false)][NotNullWhen(true)] out Type propertyType)
  {
    if (PropertyTypes.Count==0)
      BuildPropertyTypesDictionary();
    if (PropertyTypes.TryGetValue(propertyName, out propertyType))
      return true;
    var k = propertyName.IndexOf('.');
    while (k > 0)
    {
      var wildcardName = '*' + propertyName.Substring(k);
      if (PropertyTypes.TryGetValue(wildcardName, out propertyType))
        return true;
      k = propertyName.IndexOf(".", k + 1);
    }
    propertyType = null;
    return false;
  }

  #endregion

  #region Types
  public bool IsExcluded(Type type)
  {
    if (IncludedTypes.Contains(type.Name))
      return false;
    if (ExcludedNamespaces.Contains(type.Namespace ?? ""))
      return true;
    if (ExcludedTypes.Contains(type.Name))
      return true;
    return false;
  }

  public WildcardStrings ExcludedTypes { get; } = new WildcardStrings
  {
    "SR", "*Reader", "*Attribute", "*Attributes", "*Extensions", "*Helper", "*Provider", "*Methods",
    "XmlConvertingReader*", "*.Part", "EnumInfoLookup`1", "MiscAttrContainer", "ModelElement", /*"HexWord",*/
    "OpenXmlElementContext",
    "OpenXmlElementList",
    "OpenXmlSimpleType",
    "OpenXmlPackage",
    "OpenXmlPart",
    "TypedOpenXmlPart",
    "OpenXmlPartContainer",
    "IFixedContentTypePart",
    "WordAttachedToolbarsPart",
    "Worksheet*Part",
    "NamedsheetPart",
    "PivotTable*Part",
    "TableDefinitionPart",
    "QueryTablePart",
    "SingleCellTablePart",
    "SpreadsheetPrinterSettingsPart",
    "Slide*Part",
    "Notes*Part",
    "PowerPointCommentPart",
    "DocumentTasksPart",
    "Vba*Part",
    "Ribbon*Part",
    "QuickAccessToolbarCustomizationsPart",
    "WebEx*Part",
    "CustomUIPart",
    "TypedOpenXmlPackage",
    "OnOffType",
  };

  public WildcardStrings IncludedTypes { get; } = new WildcardStrings
  {
    "CustomXmlAttribute",
    "DocPart",
    //"Wordprocessing*",
    //"WordprocessingDocumentType",
    "EnumValue*",
    "OpenXmlSimpleValue*",
    "ListValue*",
    //"OpenXmlSolidColorFillPropertiesElement",
    //"OpenXmlValueColorEndPositionElement", "OpenXmlTaskAssignUnassignUserElement", "OpenXmlTaskUserElement",
    //"OpenXmlPartRootElement",
    //"OpenXmlFormulaElement",
  };

  public WildcardStrings ExcludedAttributes { get; } = new WildcardStrings
  {
    "OfficeAvailability", "NullableContext", "SchemaAttr", "Nullable", "Serializable",
    "DebuggerDisplay", "DebuggerNonUserCode", "CLSCompliant", "EditorBrowsable",
  };

  public BiDiDictionary<string, string> TypeConversion { get; } = new()
  {
    { "DocumentFormat.OpenXml.Wordprocessing.Settings", "DocumentModel.DocumentSettings"},
    { "DocumentFormat.OpenXml.Wordprocessing.WebSettings", "DocumentModel.WebSettings"},
    { "DocumentFormat.OpenXml.Wordprocessing.Fonts", "DocumentModel.Wordprocessing.Fonts"},
    { "DocumentFormat.OpenXml.StringValue", "System.String"},
    { "DocumentFormat.OpenXml.BooleanValue", "System.Boolean"},
    { "DocumentFormat.OpenXml.OnOffValue", "System.Boolean"},
    { "DocumentFormat.OpenXml.Wordprocessing.OnOffOnlyValues", "System.Boolean"},
    { "DocumentFormat.OpenXml.Office2019.Drawing.Chart.BooleanFalse", "System.Boolean"},
    { "DocumentFormat.OpenXml.Office2010.ExcelAc.List", "System.String"},
    { "DocumentFormat.OpenXml.IntegerValue", "System.Int64"},
    { "DocumentFormat.OpenXml.Int32Value", "System.Int32"},
    { "DocumentFormat.OpenXml.UInt32Value", "System.UInt32"},
    { "DocumentFormat.OpenXml.Int16Value", "System.Int16"},
    { "DocumentFormat.OpenXml.UInt16Value", "System.UInt16"},
    { "DocumentFormat.OpenXml.Int64Value", "System.Int64"},
    { "DocumentFormat.OpenXml.UInt64Value", "System.UInt16"},
    { "DocumentFormat.OpenXml.ByteValue", "System.Byte"},
    { "DocumentFormat.OpenXml.SByteValue", "System.SByte"},
    { "DocumentFormat.OpenXml.SingleValue", "System.Single"},
    { "DocumentFormat.OpenXml.DoubleValue", "System.Double"},
    { "DocumentFormat.OpenXml.DecimalValue", "System.Decimal"},
    { "DocumentFormat.OpenXml.DateTimeValue", "System.DateTime"},
    { "DocumentFormat.OpenXml.OpenXmlElement", "DocumentModel.ModelElement"},
    { "DocumentFormat.OpenXml.OpenXmlLeafElement", "System.Boolean"},
    { "DocumentFormat.OpenXml.OpenXmlLeafTextElement", "System.String"},
    { "DocumentFormat.OpenXml.Wordprocessing.LongHexNumberType", "System.UInt32"},
    { "DocumentFormat.OpenXml.EnumStringAttribute", "System.Xml.Serialization.XmlEnumAttribute"},
    { "DocumentFormat.OpenXml.OfficeAvailabilityAttribute", "DocumentModel.Attributes.OfficeAvailabilityAttribute"},
    { "DocumentFormat.OpenXml.ChildElementInfoAttribute", "DocumentModel.Attributes.ChildElementInfoAttribute"},
    { "DocumentFormat.OpenXml.SchemaAttrAttribute", "DocumentModel.Attributes.SchemaAttrAttribute"},
    { "DocumentFormat.OpenXml.VariantTypes.Variant", "DocumentModel.Variant"},
    { "DocumentFormat.OpenXml.VariantTypes.VTArray", "DocumentModel.ArrayVariant"},
    { "DocumentFormat.OpenXml.VariantTypes.VTVector", "DocumentModel.VectorVariant"},
    { "DocumentFormat.OpenXml.Base64BinaryValue", "DocumentModel.Base64Binary"},
    { "DocumentFormat.OpenXml.HexBinaryValue", "DocumentModel.HexBinary"},
  };

  public Dictionary<string, Type> ModelTypes { get; } = new();


  public void LoadModelTypes(Assembly assembly)
  {
    foreach (var type in assembly.GetTypes())
      ModelTypes.Add(type.FullName ?? "", type);
  }

  //public record TypeConversionTarget
  //{
  //  public Type Type { get; set; } = null!;
  //  public bool Rename { get; set; }

  //  public TypeConversionTarget(Type type)
  //  {
  //    Type = type;
  //  }
  //  public TypeConversionTarget(Type type, bool rename)
  //  {
  //    Type = type;
  //    Rename = rename;
  //  }

  //  public implicit operator TypeConversionTarget(Type type) => new TypeConversionTarget(type);
  //  public implicit operator TypeConversionTarget(TypeInfo typeInfo) => new TypeConversionTarget(typeInfo.Type);
  //}
  //public Dictionary<Type, TypeConversionTarget> TypeConversionTable { get; } = new()
  //{
  //  { typeof(DocumentFormat.OpenXml.StringValue), typeof(System.String)},
  //  { typeof(DocumentFormat.OpenXml.BooleanValue), typeof(System.Boolean)},
  //  { typeof(DocumentFormat.OpenXml.OnOffValue), typeof(System.Boolean)},
  //  { typeof(DocumentFormat.OpenXml.Wordprocessing.OnOffOnlyValues), typeof(System.Boolean)},
  //  { typeof(DocumentFormat.OpenXml.Office2019.Drawing.Chart.BooleanFalse), typeof(System.Boolean) },
  //  { typeof(DocumentFormat.OpenXml.Office2010.ExcelAc.List), typeof(System.String) },
  //  { typeof(DocumentFormat.OpenXml.IntegerValue), typeof(System.Int64)},
  //  { typeof(DocumentFormat.OpenXml.Int32Value), typeof(System.Int32)},
  //  { typeof(DocumentFormat.OpenXml.UInt32Value), typeof(System.UInt32)},
  //  { typeof(DocumentFormat.OpenXml.Int16Value), typeof(System.Int16)},
  //  { typeof(DocumentFormat.OpenXml.UInt16Value), typeof(System.UInt16)},
  //  { typeof(DocumentFormat.OpenXml.Int64Value), typeof(System.Int64)},
  //  { typeof(DocumentFormat.OpenXml.UInt64Value), typeof(System.UInt16)},
  //  { typeof(DocumentFormat.OpenXml.ByteValue), typeof(System.Byte)},
  //  { typeof(DocumentFormat.OpenXml.SByteValue), typeof(System.SByte)},
  //  { typeof(DocumentFormat.OpenXml.SingleValue), typeof(System.Single)},
  //  { typeof(DocumentFormat.OpenXml.DoubleValue), typeof(System.Double)},
  //  { typeof(DocumentFormat.OpenXml.DecimalValue), typeof(System.Decimal)},
  //  { typeof(DocumentFormat.OpenXml.DateTimeValue), typeof(System.DateTime)},
  //  { typeof(DocumentFormat.OpenXml.OpenXmlElement), typeof(DocumentModel.ModelElement)},
  //  { typeof(DocumentFormat.OpenXml.OpenXmlLeafElement), typeof(System.Boolean)},
  //  { typeof(DocumentFormat.OpenXml.OpenXmlLeafTextElement), typeof(System.String)},
  //  { typeof(DocumentFormat.OpenXml.Wordprocessing.LongHexNumberType), typeof(System.UInt32)},
  //  { typeof(DocumentFormat.OpenXml.EnumStringAttribute), typeof(System.Xml.Serialization.XmlEnumAttribute) },
  //  { typeof(DocumentFormat.OpenXml.OfficeAvailabilityAttribute), typeof(DocumentModel.Attributes.OfficeAvailabilityAttribute) },
  //  { typeof(DocumentFormat.OpenXml.ChildElementInfoAttribute), typeof(DocumentModel.Attributes.ChildElementInfoAttribute) },
  //  { typeof(DocumentFormat.OpenXml.SchemaAttrAttribute), typeof(DocumentModel.Attributes.SchemaAttrAttribute) },
  //  { typeof(DocumentFormat.OpenXml.VariantTypes.Variant), typeof(DocumentModel.Variant)},
  //  { typeof(DocumentFormat.OpenXml.VariantTypes.VTArray), typeof(DocumentModel.ArrayVariant)},
  //  { typeof(DocumentFormat.OpenXml.VariantTypes.VTVector), typeof(DocumentModel.VectorVariant)},
  //  { typeof(DocumentFormat.OpenXml.Base64BinaryValue), typeof(DocumentModel.Base64Binary)},
  //  { typeof(DocumentFormat.OpenXml.HexBinaryValue), typeof(DocumentModel.HexBinary)},
  //};

  public BiDiDictionary<string, string> BuiltInTypeTranslation { get; } = new()
  {
    { "System.Object", "object" },
    { "System.String", "string" },
    { "System.Boolean", "bool" },
    { "System.Int32", "int"},
    { "System.UInt32", "uint"},
    { "System.Int16", "short" },
    { "System.UInt16", "ushort" },
    { "System.Int64", "long" },
    { "System.UInt64", "ulong" },
    { "System.Byte", "byte" },
    { "System.SByte", "sbyte" },
    { "System.Single", "float" },
    { "System.Double", "double" },
    { "System.Decimal", "decimal" },
  };

  public WildcardStrings SimpleTypes { get; } = new WildcardStrings
  {
    nameof(System.String),
    nameof(System.Boolean),
    nameof(System.Int32),
    nameof(System.UInt32),
    nameof(System.Int16),
    nameof(System.UInt16),
    nameof(System.Int64),
    nameof(System.UInt64),
    nameof(System.Byte),
    nameof(System.SByte),
    nameof(System.Single),
    nameof(System.Double),
    nameof(System.Decimal),
  };

  #endregion

  #region Common type names
  public Dictionary<string, string> CommonTypes { get; } = new()
  {
    { "*Start", "*Mark" },
    { "*End", "*Mark" },
    { "MoveFromRangeMark", "EditRangeMark" },
    { "MoveToRangeMark", "EditRangeMark" },
    { "CustomXml*RangeMark", "EditRangeMark" },
    { "BookmarkMark", "AnnotationRangeMark" },
    { "CommentRangeMark", "AnnotationRangeMark" },
    { "DXW.Bidirectional*", "DXW.BidirectionalMark" },
    { "DXO10W.RunConflict*", "DXO10W.RunConflictMark" },
    { "DXW.AnnotationRangeMark|DXW.EditRangeMark|DXO10W.EditRangeMark", "DXW.RangeMark" },
    { "DXW.ProofError|DXW.PermMark", "DXW.ProofPermMark" },
    { "DXW.InsertedRun", "DXW.EditRunMark" },
    { "DXW.DeletedRun", "DXW.EditRunMark" },
    { "DXW.MoveFromRun", "DXW.EditRunMark" },
    { "DXW.MoveToRun", "DXW.EditRunMark" },
    { "DXW.ProofPermMark|DXW.RangeMark|DXW.EditRunMark|DXW.ContentPart|DXO10W.RunConflictMark", "DXW.CommonMark" },
    { "DXW.CustomXmlRun|DXW.SimpleField|DXW.Hyperlink", "DXW.ActiveRun" },
    { "DXW.ActiveRun|DXW.SdtRun|DXW.CommonMark|DXM.MathElement|DXW.Run|DXW.BidirectionalMark|DXW.SubDocumentReference", "DXW.ParagraphContent" },
    { "DXM.Accent", "DXM.MathOp" },
    { "DXM.Bar", "DXM.MathOp" },
    { "DXM.Box", "DXM.MathOp" },
    { "DXM.BorderBox", "DXM.MathOp" },
    { "DXM.Delimiter", "DXM.MathOp" },
    { "DXM.EquationArray", "DXM.MathOp" },
    { "DXM.Fraction", "DXM.MathOp" },
    { "DXM.MathFunction", "DXM.MathOp" },
    { "DXM.GroupChar", "DXM.MathOp" },
    { "DXM.LimitLower", "DXM.MathOp" },
    { "DXM.LimitUpper", "DXM.MathOp" },
    { "DXM.Matrix", "DXM.MathOp" },
    { "DXM.Nary", "DXM.MathOp" },
    { "DXM.Phantom", "DXM.MathOp" },
    { "DXM.Radical", "DXM.MathOp" },
    { "DXM.PreSubSuper", "DXM.MathOp" },
    { "DXM.Subscript", "DXM.MathOp" },
    { "DXM.SubSuperscript", "DXM.MathOp" },
    { "DXM.Superscript", "DXM.MathOp" },
    { "DXM.Run", "DXM.MathOp" },
    { "DXM.Paragraph|DXM.OfficeMath|DXM.MathOp", "DXM.MathElement" },
    { "DXW.*Border", "DXW.Border" },
    { "DXW.CustomXmlBlock|DXW.SdtBlock|DXW.Paragraph|DXW.Table", "DXW.TextBlock" },
  };

  public bool TryGetCommonTypeName(string name, [MaybeNullWhen(false)][NotNullWhen(true)] out string? newName)
  {
    if (CommonTypes.TryGetValue(name, out newName))
      return true;
    foreach (var item in CommonTypes)
    {
      if (name.IsLike(item.Key, out var wildKey, StringComparison.InvariantCulture))
      {
        newName = item.Value.Replace("*", wildKey);
        return true;
      }
    }
    newName = null;
    return false;
  }

  #endregion

  #region Validation info
  public WildcardStrings RealTypes = new()
  {
    "Int64","Int32","UInt32","Double","Boolean",
    "http://www.w3.org/2001/XMLSchema:hexBinary",
    "http://www.w3.org/2001/XMLSchema:integer",
  };
  #endregion


  #region Save & Load
  public void SaveData()
  {
    SaveData(GetFilename());
  }

  public void LoadData()
  {
    LoadData(GetFilename());
  }

  public string GetFilename()
  {
    var path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
    path = Path.Combine(path, "ModelGen");
    if (!Directory.Exists(path))
      Directory.CreateDirectory(path);
    path = Path.Combine(path, "ModelConfig.txt");
    return path;
  }

  public void SaveData(string filename)
  {
    using (var textWriter = File.CreateText(filename))
    {
      WriteStrings(textWriter, "IncludedNamespaces", IncludedNamespaces);
      WriteStrings(textWriter, "ExcludedNamespaces", ExcludedNamespaces);
      WriteDictionary(textWriter, "TranslatedNamespaces", TranslatedNamespaces);
      WriteDictionary(textWriter, "NamespaceShortcuts", NamespaceShortcuts);
      WriteDictionary(textWriter, "Heading2Namespaces", Headings2Namespaces);
      WriteStrings(textWriter, "IncludedTypes", IncludedTypes);
      WriteStrings(textWriter, "ExcludedTypes", ExcludedTypes);
      WriteStrings(textWriter, "ExcludedAttributes", ExcludedAttributes);
      WriteDictionary(textWriter, "TypeConversion", TypeConversion);
      WriteDictionary(textWriter, "PropertyTypeTranslation", PropertyTypeConversion);
      WriteDictionary(textWriter, "BuiltInTypeTranslation", BuiltInTypeTranslation);
      WriteStrings(textWriter, "SimpleTypes", SimpleTypes);
      WriteStrings(textWriter, "RealTypes", RealTypes);
      WriteDictionary(textWriter, "CommonTypes", CommonTypes);
    }
  }

  public void LoadData(string filename)
  {
    using (var textReader = File.OpenText(filename))
    {
      string? line;
      int lineNumber = 0;
      while ((line = textReader.ReadLine()) != null)
      {
        lineNumber++;
        line = line.Trim();
        if (line.Length == 0)
          continue;
        if (line.StartsWith("[") && line.EndsWith("]"))
        {
          var key = line.Substring(1, line.Length - 2);
          if (key == "IncludedNamespaces")
            ReadStrings(textReader, IncludedNamespaces, ref lineNumber);
          else if (key == "ExcludedNamespaces")
            ReadStrings(textReader, ExcludedNamespaces, ref lineNumber);
          else if (key == "TranslatedNamespaces")
            ReadDictionary(textReader, TranslatedNamespaces, ref lineNumber);
          else if (key == "NamespaceShortcuts")
            ReadDictionary(textReader, NamespaceShortcuts, ref lineNumber);
          else if (key == "Headings2Namespaces")
            ReadDictionary(textReader, Headings2Namespaces, ref lineNumber);
          else if (key == "IncludedTypes")
            ReadStrings(textReader, IncludedTypes, ref lineNumber);
          else if (key == "ExcludedTypes")
            ReadStrings(textReader, ExcludedTypes, ref lineNumber);
          else if (key == "ExcludedAttributes")
            ReadStrings(textReader, ExcludedAttributes, ref lineNumber);
          else if (key == "TypeConversion")
            ReadDictionary(textReader, TypeConversion, ref lineNumber);
          else if (key == "PropertyTypeConversion")
          {
            ReadDictionary(textReader, PropertyTypeConversion, ref lineNumber);
            PropertyTypes.Clear();
          }
          else if (key == "BuiltInTypeTranslation")
            ReadDictionary(textReader, BuiltInTypeTranslation, ref lineNumber);
          else if (key == "SimpleTypes")
            ReadStrings(textReader, SimpleTypes, ref lineNumber);
          else if (key == "RealTypes")
            ReadStrings(textReader, RealTypes, ref lineNumber);
          else if (key == "CommonTypes")
            ReadDictionary(textReader, CommonTypes, ref lineNumber);
          else
            throw new InvalidDataException($"Unrecognized key [{key}] expected in line {lineNumber}");
        }
        else
          throw new InvalidDataException($"[key] expected in line {lineNumber}");
      }
    }
  }


  private void WriteStrings(TextWriter textWriter, string caption, ICollection<string> data)
  {
    textWriter.WriteLine("[" + caption + "]");
    foreach (var item in data)
      textWriter.WriteLine(item);
    textWriter.WriteLine();
  }

  private void WriteDictionary(TextWriter textWriter, string caption, IDictionary<string, string> data)
  {
    textWriter.WriteLine("[" + caption + "]");
    foreach (var item in data)
      textWriter.WriteLine($"{item.Key}\t{item.Value}");
    textWriter.WriteLine();
  }


  private void ReadStrings(TextReader textReader, ICollection<string> data, ref int lineNumber)
  {
    data.Clear();
    string? line;
    while (!(String.IsNullOrEmpty(line = textReader.ReadLine())))
    {
      lineNumber++;
      try
      {
        data.Add(line.Trim());
      }
      catch (Exception ex)
      { throw new InvalidDataException($"{ex.Message} in line {lineNumber}"); }
    }
    lineNumber++;
  }

  private void ReadDictionary(TextReader textReader, IDictionary<string, string> data, ref int lineNumber)
  {
    data.Clear();
    string? line;
    while (!(String.IsNullOrEmpty(line = textReader.ReadLine())))
    {
      lineNumber++;
      var ss = line.Trim().Split('\t');
      try
      {
        if (ss.Length > 1)
          data.Add(ss[0], ss[1]);
        else
          data.Add(ss[0], string.Empty);
      }
      catch (Exception ex)
      { throw new InvalidDataException($"{ex.Message} in line {lineNumber}"); }
    }
    lineNumber++;

  }
  #endregion
}
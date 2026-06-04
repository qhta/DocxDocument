namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies a paper size.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdpapersize?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType(typeof(Microsoft.Office.Interop.Word.WdPaperSize))]
public enum PaperSize
{
  /// <summary>
  /// Specifies a paper size.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPaperSize.wdPaper10x14))]
  Size10x14 = 0,
  /// <summary>
  /// Specifies a paper size.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPaperSize.wdPaper11x17))]
  Size11x17 = 1,
  /// <summary>
  /// Letter dimensions.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPaperSize.wdPaperLetter))]
  Letter = 2,
  /// <summary>
  /// Small letter dimensions.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPaperSize.wdPaperLetterSmall))]
  LetterSmall = 3,
  /// <summary>
  /// Legal dimensions.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPaperSize.wdPaperLegal))]
  Legal = 4,
  /// <summary>
  /// Executive dimensions.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPaperSize.wdPaperExecutive))]
  Executive = 5,
  /// <summary>
  /// A3 dimensions.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPaperSize.wdPaperA3))]
  A3 = 6,
  /// <summary>
  /// A4 dimensions.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPaperSize.wdPaperA4))]
  A4 = 7,
  /// <summary>
  /// Small A4 dimensions.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPaperSize.wdPaperA4Small))]
  A4Small = 8,
  /// <summary>
  /// A5 dimensions.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPaperSize.wdPaperA5))]
  A5 = 9,
  /// <summary>
  /// B4 dimensions.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPaperSize.wdPaperB4))]
  B4 = 10,
  /// <summary>
  /// B5 dimensions.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPaperSize.wdPaperB5))]
  B5 = 11,
  /// <summary>
  /// C sheet dimensions.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPaperSize.wdPaperCSheet))]
  CSheet = 12,
  /// <summary>
  /// D sheet dimensions.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPaperSize.wdPaperDSheet))]
  DSheet = 13,
  /// <summary>
  /// E sheet dimensions.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPaperSize.wdPaperESheet))]
  ESheet = 14,
  /// <summary>
  /// German legal fanfold dimensions.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPaperSize.wdPaperFanfoldLegalGerman))]
  FanfoldLegalGerman = 15,
  /// <summary>
  /// German standard fanfold dimensions.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPaperSize.wdPaperFanfoldStdGerman))]
  FanfoldStdGerman = 16,
  /// <summary>
  /// United States fanfold dimensions.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPaperSize.wdPaperFanfoldUS))]
  FanfoldUS = 17,
  /// <summary>
  /// Folio dimensions.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPaperSize.wdPaperFolio))]
  Folio = 18,
  /// <summary>
  /// Ledger dimensions.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPaperSize.wdPaperLedger))]
  Ledger = 19,
  /// <summary>
  /// Note dimensions.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPaperSize.wdPaperNote))]
  Note = 20,
  /// <summary>
  /// Quarto dimensions.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPaperSize.wdPaperQuarto))]
  Quarto = 21,
  /// <summary>
  /// Statement dimensions.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPaperSize.wdPaperStatement))]
  Statement = 22,
  /// <summary>
  /// Tabloid dimensions.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPaperSize.wdPaperTabloid))]
  Tabloid = 23,
  /// <summary>
  /// Envelope, size 9.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPaperSize.wdPaperEnvelope9))]
  Envelope9 = 24,
  /// <summary>
  /// Legal envelope, size 10.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPaperSize.wdPaperEnvelope10))]
  Envelope10 = 25,
  /// <summary>
  /// Envelope, size 11.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPaperSize.wdPaperEnvelope11))]
  Envelope11 = 26,
  /// <summary>
  /// Envelope, size 12.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPaperSize.wdPaperEnvelope12))]
  Envelope12 = 27,
  /// <summary>
  /// Envelope, size 14.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPaperSize.wdPaperEnvelope14))]
  Envelope14 = 28,
  /// <summary>
  /// B4 envelope.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPaperSize.wdPaperEnvelopeB4))]
  EnvelopeB4 = 29,
  /// <summary>
  /// B5 envelope.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPaperSize.wdPaperEnvelopeB5))]
  EnvelopeB5 = 30,
  /// <summary>
  /// B6 envelope.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPaperSize.wdPaperEnvelopeB6))]
  EnvelopeB6 = 31,
  /// <summary>
  /// C3 envelope.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPaperSize.wdPaperEnvelopeC3))]
  EnvelopeC3 = 32,
  /// <summary>
  /// C4 envelope.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPaperSize.wdPaperEnvelopeC4))]
  EnvelopeC4 = 33,
  /// <summary>
  /// C5 envelope.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPaperSize.wdPaperEnvelopeC5))]
  EnvelopeC5 = 34,
  /// <summary>
  /// C6 envelope.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPaperSize.wdPaperEnvelopeC6))]
  EnvelopeC6 = 35,
  /// <summary>
  /// C65 envelope.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPaperSize.wdPaperEnvelopeC65))]
  EnvelopeC65 = 36,
  /// <summary>
  /// DL envelope.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPaperSize.wdPaperEnvelopeDL))]
  EnvelopeDL = 37,
  /// <summary>
  /// Italian envelope.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPaperSize.wdPaperEnvelopeItaly))]
  EnvelopeItaly = 38,
  /// <summary>
  /// Monarch envelope.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPaperSize.wdPaperEnvelopeMonarch))]
  EnvelopeMonarch = 39,
  /// <summary>
  /// Personal envelope.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPaperSize.wdPaperEnvelopePersonal))]
  EnvelopePersonal = 40,
  /// <summary>
  /// Custom paper size.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdPaperSize.wdPaperCustom))]
  Custom = 41
}

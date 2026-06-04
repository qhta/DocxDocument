namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies a paper size.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdpapersize?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Interop.Word.WdPaperSize")]
public enum PaperSize
{
  /// <summary>
  /// Specifies a paper size.
  /// </summary>
  [InteropEnumValue("wdPaper10x14")]
  Size10x14 = 0,
  /// <summary>
  /// Specifies a paper size.
  /// </summary>
  [InteropEnumValue("wdPaper11x17")]
  Size11x17 = 1,
  /// <summary>
  /// Letter dimensions.
  /// </summary>
  [InteropEnumValue("wdPaperLetter")]
  Letter = 2,
  /// <summary>
  /// Small letter dimensions.
  /// </summary>
  [InteropEnumValue("wdPaperLetterSmall")]
  LetterSmall = 3,
  /// <summary>
  /// Legal dimensions.
  /// </summary>
  [InteropEnumValue("wdPaperLegal")]
  Legal = 4,
  /// <summary>
  /// Executive dimensions.
  /// </summary>
  [InteropEnumValue("wdPaperExecutive")]
  Executive = 5,
  /// <summary>
  /// A3 dimensions.
  /// </summary>
  [InteropEnumValue("wdPaperA3")]
  A3 = 6,
  /// <summary>
  /// A4 dimensions.
  /// </summary>
  [InteropEnumValue("wdPaperA4")]
  A4 = 7,
  /// <summary>
  /// Small A4 dimensions.
  /// </summary>
  [InteropEnumValue("wdPaperA4Small")]
  A4Small = 8,
  /// <summary>
  /// A5 dimensions.
  /// </summary>
  [InteropEnumValue("wdPaperA5")]
  A5 = 9,
  /// <summary>
  /// B4 dimensions.
  /// </summary>
  [InteropEnumValue("wdPaperB4")]
  B4 = 10,
  /// <summary>
  /// B5 dimensions.
  /// </summary>
  [InteropEnumValue("wdPaperB5")]
  B5 = 11,
  /// <summary>
  /// C sheet dimensions.
  /// </summary>
  [InteropEnumValue("wdPaperCSheet")]
  CSheet = 12,
  /// <summary>
  /// D sheet dimensions.
  /// </summary>
  [InteropEnumValue("wdPaperDSheet")]
  DSheet = 13,
  /// <summary>
  /// E sheet dimensions.
  /// </summary>
  [InteropEnumValue("wdPaperESheet")]
  ESheet = 14,
  /// <summary>
  /// German legal fanfold dimensions.
  /// </summary>
  [InteropEnumValue("wdPaperFanfoldLegalGerman")]
  FanfoldLegalGerman = 15,
  /// <summary>
  /// German standard fanfold dimensions.
  /// </summary>
  [InteropEnumValue("wdPaperFanfoldStdGerman")]
  FanfoldStdGerman = 16,
  /// <summary>
  /// United States fanfold dimensions.
  /// </summary>
  [InteropEnumValue("wdPaperFanfoldUS")]
  FanfoldUS = 17,
  /// <summary>
  /// Folio dimensions.
  /// </summary>
  [InteropEnumValue("wdPaperFolio")]
  Folio = 18,
  /// <summary>
  /// Ledger dimensions.
  /// </summary>
  [InteropEnumValue("wdPaperLedger")]
  Ledger = 19,
  /// <summary>
  /// Note dimensions.
  /// </summary>
  [InteropEnumValue("wdPaperNote")]
  Note = 20,
  /// <summary>
  /// Quarto dimensions.
  /// </summary>
  [InteropEnumValue("wdPaperQuarto")]
  Quarto = 21,
  /// <summary>
  /// Statement dimensions.
  /// </summary>
  [InteropEnumValue("wdPaperStatement")]
  Statement = 22,
  /// <summary>
  /// Tabloid dimensions.
  /// </summary>
  [InteropEnumValue("wdPaperTabloid")]
  Tabloid = 23,
  /// <summary>
  /// Envelope, size 9.
  /// </summary>
  [InteropEnumValue("wdPaperEnvelope9")]
  Envelope9 = 24,
  /// <summary>
  /// Legal envelope, size 10.
  /// </summary>
  [InteropEnumValue("wdPaperEnvelope10")]
  Envelope10 = 25,
  /// <summary>
  /// Envelope, size 11.
  /// </summary>
  [InteropEnumValue("wdPaperEnvelope11")]
  Envelope11 = 26,
  /// <summary>
  /// Envelope, size 12.
  /// </summary>
  [InteropEnumValue("wdPaperEnvelope12")]
  Envelope12 = 27,
  /// <summary>
  /// Envelope, size 14.
  /// </summary>
  [InteropEnumValue("wdPaperEnvelope14")]
  Envelope14 = 28,
  /// <summary>
  /// B4 envelope.
  /// </summary>
  [InteropEnumValue("wdPaperEnvelopeB4")]
  EnvelopeB4 = 29,
  /// <summary>
  /// B5 envelope.
  /// </summary>
  [InteropEnumValue("wdPaperEnvelopeB5")]
  EnvelopeB5 = 30,
  /// <summary>
  /// B6 envelope.
  /// </summary>
  [InteropEnumValue("wdPaperEnvelopeB6")]
  EnvelopeB6 = 31,
  /// <summary>
  /// C3 envelope.
  /// </summary>
  [InteropEnumValue("wdPaperEnvelopeC3")]
  EnvelopeC3 = 32,
  /// <summary>
  /// C4 envelope.
  /// </summary>
  [InteropEnumValue("wdPaperEnvelopeC4")]
  EnvelopeC4 = 33,
  /// <summary>
  /// C5 envelope.
  /// </summary>
  [InteropEnumValue("wdPaperEnvelopeC5")]
  EnvelopeC5 = 34,
  /// <summary>
  /// C6 envelope.
  /// </summary>
  [InteropEnumValue("wdPaperEnvelopeC6")]
  EnvelopeC6 = 35,
  /// <summary>
  /// C65 envelope.
  /// </summary>
  [InteropEnumValue("wdPaperEnvelopeC65")]
  EnvelopeC65 = 36,
  /// <summary>
  /// DL envelope.
  /// </summary>
  [InteropEnumValue("wdPaperEnvelopeDL")]
  EnvelopeDL = 37,
  /// <summary>
  /// Italian envelope.
  /// </summary>
  [InteropEnumValue("wdPaperEnvelopeItaly")]
  EnvelopeItaly = 38,
  /// <summary>
  /// Monarch envelope.
  /// </summary>
  [InteropEnumValue("wdPaperEnvelopeMonarch")]
  EnvelopeMonarch = 39,
  /// <summary>
  /// Personal envelope.
  /// </summary>
  [InteropEnumValue("wdPaperEnvelopePersonal")]
  EnvelopePersonal = 40,
  /// <summary>
  /// Custom paper size.
  /// </summary>
  [InteropEnumValue("wdPaperCustom")]
  Custom = 41
}

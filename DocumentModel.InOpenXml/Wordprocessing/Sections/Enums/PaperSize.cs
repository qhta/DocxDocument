namespace DocumentModel.Wordprocessing;

/// <summary>
///   Specifies the paper size for a section or page in a WordprocessingML document.
///   Values correspond to standard ISO, ANSI, and regional paper sizes used for printing and layout.
/// </summary>
[OpenXmlNotMapped]
public enum PaperSize {
  /// <summary>Letter (8.5 x 11 in, North American standard)</summary>
  Letter = 1,
  /// <summary>Letter Small (8.5 x 11 in, small margins)</summary>
  LetterSmall = 2,
  /// <summary>Tabloid (11 x 17 in)</summary>
  Tabloid = 3,
  /// <summary>Ledger (17 x 11 in)</summary>
  Ledger = 4,
  /// <summary>Legal (8.5 x 14 in)</summary>
  Legal = 5,
  /// <summary>Statement (5.5 x 8.5 in)</summary>
  Statement = 6,
  /// <summary>Executive (7.25 x 10.5 in)</summary>
  Executive = 7,
  /// <summary>A3 (297 x 420 mm, ISO)</summary>
  A3 = 8,
  /// <summary>A4 (210 x 297 mm, ISO)</summary>
  A4 = 9,
  /// <summary>A4 Small (210 x 297 mm, small margins)</summary>
  A4Small = 10,
  /// <summary>A5 (148 x 210 mm, ISO)</summary>
  A5 = 11,
  /// <summary>B4 (250 x 353 mm, ISO)</summary>
  B4 = 12,
  /// <summary>B5 (176 x 250 mm, ISO)</summary>
  B5 = 13,
  /// <summary>Folio (8.5 x 13 in)</summary>
  Folio = 14,
  /// <summary>Quarto (215 x 275 mm)</summary>
  Quarto = 15,
  /// <summary>10 x 14 in sheet</summary>
  Sheet10x14 = 16,
  /// <summary>11 x 17 in sheet</summary>
  Sheet11x17 = 17,
  /// <summary>Note (8.5 x 11 in, narrow margins)</summary>
  Note = 18,
  /// <summary>Envelope #9 (3.875 x 8.875 in)</summary>
  Envelope9 = 19,
  /// <summary>Envelope #10 (4.125 x 9.5 in)</summary>
  Envelope10 = 20,
  /// <summary>Envelope #11 (4.5 x 10.375 in)</summary>
  Envelope11 = 21,
  /// <summary>Envelope #12 (4.75 x 11 in)</summary>
  Envelope12 = 22,
  /// <summary>Envelope #14 (5 x 11.5 in)</summary>
  Envelope14 = 23,
  /// <summary>C size sheet (17 x 22 in)</summary>
  Csheet = 24,
  /// <summary>D size sheet (22 x 34 in)</summary>
  Dsheet = 25,
  /// <summary>E size sheet (34 x 44 in)</summary>
  Esheet = 26,
  /// <summary>Envelope DL (110 x 220 mm, ISO)</summary>
  EnvelopeDL = 27,
  /// <summary>Envelope C5 (162 x 229 mm, ISO)</summary>
  EnvelopeC5 = 28,
  /// <summary>Envelope C3 (324 x 458 mm, ISO)</summary>
  EnvelopeC3 = 29,
  /// <summary>Envelope C4 (229 x 324 mm, ISO)</summary>
  EnvelopeC4 = 30,
  /// <summary>Envelope C6 (114 x 162 mm, ISO)</summary>
  EnvelopeC6 = 31,
  /// <summary>Envelope C65 (114 x 229 mm, ISO)</summary>
  EnvelopeC65 = 32,
  /// <summary>Envelope B4 (250 x 353 mm, ISO)</summary>
  EnvelopeB4 = 33,
  /// <summary>Envelope B5 (176 x 250 mm, ISO)</summary>
  EnvelopeB5 = 34,
  /// <summary>Envelope B6 (176 x 125 mm, ISO)</summary>
  EnvelopeB6 = 35,
  /// <summary>Envelope Italy (110 x 230 mm)</summary>
  EnvelopeItaly = 36,
  /// <summary>Envelope Monarch (3.875 x 7.5 in)</summary>
  EnvelopeMonarch = 37,
  /// <summary>Envelope Personal (3.625 x 6.5 in)</summary>
  EnvelopePersonal = 38,
  /// <summary>US Fanfold (14.875 x 11 in)</summary>
  FanfoldUS = 39,
  /// <summary>German Standard Fanfold (8.5 x 12 in)</summary>
  FanfoldStdGerman = 40,
  /// <summary>German Legal Fanfold (8.5 x 13 in)</summary>
  FanfoldLegalGerman = 41,
  /// <summary>Japan Postcard (100 x 148 mm)</summary>
  JapanPostCard = 43,
  /// <summary>A6 (105 x 148 mm, ISO)</summary>
  A6 = 70,
  /// <summary>Envelope Chou #3 (120 x 235 mm, Japan)</summary>
  EnvelopeChou3 = 73,
  /// <summary>Envelope Chou #4 (90 x 205 mm, Japan)</summary>
  EnvelopeChou4 = 74,
  /// <summary>4 x 6 in sheet</summary>
  Sheet4x6 = 125,
  /// <summary>5 x 7 in sheet</summary>
  Sheet5x7 = 126,
  /// <summary>3.5 x 5 in sheet</summary>
  Sheet3_5x5 = 127,
  /// <summary>2L size sheet (127 x 178 mm, Japan)</summary>
  Sheet2L = 128,
  /// <summary>8 x 10 in sheet</summary>
  Sheet8x10 = 129,
  /// <summary>Ofuku Hagaki (Japanese double postcard, 148 x 200 mm)</summary>
  OfukuHagaki = 130,
  /// <summary>Envelope A2 (4.375 x 5.75 in)</summary>
  EnvelopeA2 = 131,
  /// <summary>Card 4 x 6 in</summary>
  Card4x6 = 132,
  /// <summary>Card 5 x 6 in</summary>
  Card5x6 = 133,
  /// <summary>Card Letter size (8.5 x 11 in)</summary>
  CardLetter = 134,
  /// <summary>Card A4 size (210 x 297 mm)</summary>
  CardA4 = 135,
  /// <summary>8.5 x 13 in sheet</summary>
  Sheet8_5x13 = 136,
  /// <summary>B5 ISO (176 x 250 mm, ISO)</summary>
  B5ISO = 137,
  /// <summary>User-defined paper size</summary>
  User = 256,
};

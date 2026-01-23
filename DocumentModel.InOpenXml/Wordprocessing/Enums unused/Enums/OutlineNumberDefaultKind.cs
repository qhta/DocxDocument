namespace DocumentModel.Wordprocessing;

/// <summary>
///   Specifies the default outline numbering scheme.
/// </summary>
public enum OutlineNumberDefaultKind
{
  /// <summary>Arabic outline numbering (1., 1.1., 1.1.1...)</summary>
  Arabic = 0,
  /// <summary>Chapter outline (Chapter 1, 1.1, 1.1.1...)</summary>
  Chapter = 1,
  /// <summary>Article outline (Article I, Section 1.01...)</summary>
  Article = 2,
  /// <summary>Legal outline (1., 1.1, 1.1.1...)</summary>
  Legal = 3
}
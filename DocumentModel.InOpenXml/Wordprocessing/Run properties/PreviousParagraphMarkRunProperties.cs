namespace DocumentModel.Wordprocessing;

  /// <summary>
  /// Represents the previous version of paragraph mark run properties, used in <see cref="ParagraphMarkRunPropertiesChange"/>.
  /// This interface extends <see cref="BaseParagraphMarkRunProperties"/> and is used to store the state of paragraph mark formatting before a tracked change, enabling comparison and revision management in WordprocessingML documents.
  /// </summary>
  public interface PreviousParagraphMarkRunProperties : BaseParagraphMarkRunProperties
  {
  }
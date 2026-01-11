namespace DocumentModel.Wordprocessing;

  /// <summary>
  /// Represents a collection of document variables in a WordprocessingML document.
  /// This interface provides access to and management of <see cref="Variable"/> objects, enabling advanced storage, retrieval, and organization of custom metadata or automation variables within the document.
  /// </summary>
  public interface Variables : ElementCollection<Variable>
  {
    
  }
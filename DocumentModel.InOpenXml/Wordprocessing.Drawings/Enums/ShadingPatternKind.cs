namespace DocumentModel.Wordprocessing.Drawings;

  /// <summary>
  /// Specifies the shading pattern options for graphical elements in WordprocessingML drawings.
  /// This enumeration provides values for various fill and pattern styles, supporting advanced visual effects and background fills for shapes, tables, and other graphical content within the document.
  /// </summary>
  [JsonConverter(typeof(StringEnumConverter))
  ]
  public enum ShadingPatternKind
  {
    
    /// <summary>
    /// No pattern.
    /// </summary>
    Nil,
    
    /// <summary>
    /// No pattern (clear fill).
    /// </summary>
    Clear,
    
    /// <summary>
    /// 100% fill pattern (solid fill).
    /// </summary>
    Solid,
    
    /// <summary>
    /// Horizontal stripe pattern.
    /// </summary>
    HorizontalStripe,
    
    /// <summary>
    /// Vertical stripe pattern.
    /// </summary>
    VerticalStripe,
    
    /// <summary>
    /// Reverse diagonal stripe pattern.
    /// </summary>
    ReverseDiagonalStripe,
    
    /// <summary>
    /// Diagonal stripe pattern.
    /// </summary>
    DiagonalStripe,
    
    /// <summary>
    /// Horizontal cross pattern.
    /// </summary>
    HorizontalCross,
    
    /// <summary>
    /// Diagonal cross pattern.
    /// </summary>
    DiagonalCross,
    
    /// <summary>
    /// Thin horizontal stripe pattern.
    /// </summary>
    ThinHorizontalStripe,
    
    /// <summary>
    /// Thin vertical stripe pattern.
    /// </summary>
    ThinVerticalStripe,
    
    /// <summary>
    /// Thin reverse diagonal stripe pattern.
    /// </summary>
    ThinReverseDiagonalStripe,
    
    /// <summary>
    /// Thin diagonal stripe pattern.
    /// </summary>
    ThinDiagonalStripe,
    
    /// <summary>
    /// Thin horizontal cross pattern.
    /// </summary>
    ThinHorizontalCross,
    
    /// <summary>
    /// Thin diagonal cross pattern.
    /// </summary>
    ThinDiagonalCross,
    
    /// <summary>
    /// 5% fill pattern.
    /// </summary>
    Percent5,
    
    /// <summary>
    /// 10% fill pattern.
    /// </summary>
    Percent10,
    
    /// <summary>
    /// 12.5% fill pattern.
    /// </summary>
    Percent12,
    
    /// <summary>
    /// 15% fill pattern.
    /// </summary>
    Percent15,
    
    /// <summary>
    /// 20% fill pattern.
    /// </summary>
    Percent20,
    
    /// <summary>
    /// 25% fill pattern.
    /// </summary>
    Percent25,
    
    /// <summary>
    /// 30% fill pattern.
    /// </summary>
    Percent30,
    
    /// <summary>
    /// 35% fill pattern.
    /// </summary>
    Percent35,
    
    /// <summary>
    /// 37.5% fill pattern.
    /// </summary>
    Percent37,
    
    /// <summary>
    /// 40% fill pattern.
    /// </summary>
    Percent40,
    
    /// <summary>
    /// 45% fill pattern.
    /// </summary>
    Percent45,
    
    /// <summary>
    /// 50% fill pattern.
    /// </summary>
    Percent50,
    
    /// <summary>
    /// 55% fill pattern.
    /// </summary>
    Percent55,
    
    /// <summary>
    /// 60% fill pattern.
    /// </summary>
    Percent60,
    
    /// <summary>
    /// 62.5% fill pattern.
    /// </summary>
    Percent62,
    
    /// <summary>
    /// 65% fill pattern.
    /// </summary>
    Percent65,
    
    /// <summary>
    /// 70% fill pattern.
    /// </summary>
    Percent70,
    
    /// <summary>
    /// 75% fill pattern.
    /// </summary>
    Percent75,
    
    /// <summary>
    /// 80% fill pattern.
    /// </summary>
    Percent80,
    
    /// <summary>
    /// 85% fill pattern.
    /// </summary>
    Percent85,
    
    /// <summary>
    /// 87.5% fill pattern.
    /// </summary>
    Percent87,
    
    /// <summary>
    /// 90% fill pattern.
    /// </summary>
    Percent90,
    
    /// <summary>
    /// 95% fill pattern.
    /// </summary>
    Percent95
  }
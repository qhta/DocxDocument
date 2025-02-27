﻿using System;

namespace DocumentModel.Attributes
{
  /// <summary>
  /// Defines the Office Open XML file format version.
  /// </summary>
  [Flags]
  public enum FileFormatVersions
  {
    /// <summary>
    /// Represents an invalid value which will cause an exception.
    /// </summary>
    None = 0,

    /// <summary>
    /// Represents Microsoft Office 2007.
    /// </summary>
    Office2007 = 0x1,

    /// <summary>
    /// Represents Microsoft Office 2010.
    /// </summary>
    Office2010 = 0x2,

    /// <summary>
    /// Represents Microsoft Office 2013.
    /// </summary>
    Office2013 = 0x4,

    /// <summary>
    /// Represents Microsoft Office 2016.
    /// </summary>
    Office2016 = 0x8,

    /// <summary>
    /// Represents Microsoft Office 2019.
    /// </summary>
    Office2019 = 0x10,

    /// <summary>
    /// Represents Microsoft Office 2021.
    /// </summary>
    Office2021 = 0x20,

    /// <summary>
    /// Represents Microsoft 365.
    /// </summary>
    Microsoft365 = 0x40000000,
  }

}
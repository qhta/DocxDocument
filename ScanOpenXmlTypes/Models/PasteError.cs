using System;
using System.Collections.Generic;

namespace YourNamespace.Models;

public partial class PasteError
{
    public string? StartCp { get; set; }

    public string? EndCp { get; set; }

    public string? WritingSystem { get; set; }

    public string? RangeName { get; set; }

    public string? For { get; set; }

    public string? Comment { get; set; }
}

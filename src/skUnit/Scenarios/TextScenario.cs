﻿using skUnit.Scenarios.Parsers.Assertions;

namespace skUnit.Scenarios;

public class TextScenario : Scenario
{
    public string? Prompt { get; set; }
    public string? Description { get; set; }
    public required string RawText { get; set; }
    public Dictionary<string, string> Parameters { get; set; } = new();
    public List<IKernelAssertion> Assertions { get; set; } = new();
    public string? ExpectedAnswer { get; set; }
}
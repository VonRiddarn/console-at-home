using System;

namespace ConsoleAtHome;

public record struct MenuAction(string Label, Action Action);
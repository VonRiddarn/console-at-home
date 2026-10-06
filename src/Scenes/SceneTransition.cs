namespace ConsoleAtHome;

public abstract record SceneTransition
{
	public sealed record Push(IScene Scene) : SceneTransition;
	public sealed record Replace(IScene Scene) : SceneTransition;
	public sealed record Pop() : SceneTransition;
}
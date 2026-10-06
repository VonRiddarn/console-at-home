namespace ConsoleAtHome;

public interface IScene
{
	public void Enter();
	public void Exit();

	public SceneTransition Run();
}
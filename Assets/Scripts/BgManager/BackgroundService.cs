
public class BackgroundService
{
    private AnimationController _bgUIController;
    private AnimationController baseController;

    public BackgroundService(AnimationView bgUIView,float bgOffset,AnimationView baseView,float baseOffset)
    {
        _bgUIController = new AnimationController(bgOffset,bgUIView);
        baseController = new AnimationController(baseOffset,baseView);

    }
}


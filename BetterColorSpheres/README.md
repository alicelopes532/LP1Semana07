classDiagram
    class Color 
    {
        private Color color;
        private Radius radius;
        private TimesThrown timesthrown;
        {   
            public Sphere()
            {
                color = new Color();
                radius = new Radius();
                timesthrown = new TimesThrown();
            }
        }
    }
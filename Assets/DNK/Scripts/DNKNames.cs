namespace DNK
{
    namespace Scene
    {
        public enum SceneNames
        {
            Title,
            InGame,
            GameClear,
        }

    }

    namespace Player
    {
        public enum PlayerState
        {
            Idle,
            Walk,
            Dead,
        }

        public enum PlayerGrabState
        {
            Idle,
            Grab,
        }
    }

    namespace Girl
    {
        public enum GirlState
        {
            Idle,
            Walk
        }

        public enum GirlGrabState
        {
            None,
            AFlower,
            Flowers,
            Bouquet,
        }

        public enum GirlClothState
        {
            Normal,
            Dress,
        }

        public enum GirlRingState
        {
            None,
            Ring,
        }
    }

    namespace Item
    {
        public enum ItemNames
        {
            None,
            Branch,
            Dress,
            Ring,
            Flower,
            Cloth,
            Stone,
        }
    }
}

﻿namespace ink_ribbon_profile_api.Domain.Dto.Steam
{
    public class ResolveVanityDto
    {
        public required string steamid { get; set; }
        public int success { get; set; }
    }

    public class Root
    {
        public required Response response { get; set; }
    }
}

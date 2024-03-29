﻿using System;
using System.Collections.Generic;

namespace NFTMarket.Models
{
    public class NFT
    { 
        public List<NFT> GetTrendingNFTs()
        {
            return new List<NFT>()
            {
                new NFT{ Name = "3D Art", Image = "3DArt.png", Value = 88055.12, Valuation = 3.99, Likes = 234},
                new NFT{ Name = "Abstract Art", Image = "AbstractArt.png", Value = 10055.06, Valuation = 3.99, Likes = 121},
                new NFT{ Name = "Portrait Art", Image = "PortraitArt.png", Value = 9095.27, Valuation = 3.99, Likes = 112},
                new NFT{ Name = "Virtual", Image = "Virtual.png", Value = 9095.27, Valuation = 3.99, Likes  = 110}
            };
        }

        public List<NFT> GetTopSeller()
        {
            return new List<NFT>()
            {
                new NFT{ Name = "Wave", Image = "Wave.png", Value = 0.46, Valuation = 3.99, Likes = 200, Description = "wav2 #5672"},
                new NFT{ Name = "Abstract Pink", Image = "AbstractPink.png", Value = 0.56, Valuation = 3.99, Likes = 129, Description = "abstract #2538"},
                new NFT{ Name = "WaveBlue", Image = "WaveBlue.png", Value = 0.233, Valuation = 3.99, Likes = 156, Description = "wavepi #5267"},
                new NFT{ Name = "Abstract23", Image = "Abstract23.png", Value = 0.49, Valuation = 3.99, Likes =136, Description = "abstract #2038"}
            };
        }

        public List<NFT> GetNFTList()
        {
            return new List<NFT>()
            {
                new NFT{ Name = "Azumi", Image = "Wave.png", Value = 200055.46, Valuation = 3.99, Likes = 200, Description = "wav2 #5672"},
                new NFT{ Name = "Abstract Pink", Image = "AbstractPink.png", Value = 180055.45, Valuation = 33.79, Likes = 129, Description = "abstract #2538"},
                new NFT{ Name = "WaveBlue", Image = "WaveBlue.png", Value = 90055.62, Valuation = -6.56, Likes = 156, Description = "wavepi #5267"},
                new NFT{ Name = "Abstract23", Image = "Abstract23.png", Value = 88055.12, Valuation = 9.99, Likes =136, Description = "abstract #2038"},
                new NFT{ Name = "Avery", Image = "Wave.png", Value = 200055.46, Valuation = -3.99, Likes = 200, Description = "wav2 #5672"},
                new NFT{ Name = "Abstract help", Image = "AbstractPink.png", Value = 180055.45, Valuation = -23.49, Likes = 129, Description = "abstract #2538"},
                new NFT{ Name = "Wave", Image = "WaveBlue.png", Value = 90055.62, Valuation = 3.99, Likes = 156, Description = "wavepi #5267"},
                new NFT{ Name = "Abstract", Image = "Abstract23.png", Value = 88055.12, Valuation = 7.29, Likes =136, Description = "abstract #2038"}
            };
        }

        public string Name { get; set; }
        public double Value { get; set; }
        public object Valuation { get; set; }
        public int Likes { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
    }
}

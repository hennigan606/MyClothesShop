namespace MyClothesShop.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using MyClothesShop.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<MyClothesShop.Models.ProductDb>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(MyClothesShop.Models.ProductDb context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            context.Products.AddOrUpdate(r => r.Name,

                new Product
                {
                    Name = "Brown Brogues",
                    Section = 0,
                    Category = 0,
                    Gender = 0,
                    Price = 99.99m,
                    Image = "~/Resources/BrownBrogues.jpg",
                    Description = "Step out in classic style with this men's sacchetto lace-up in premium leather. " +
                    "The timeless perforated designs and simple lace closure system give it that business-like look " +
                    "that's ideal for the board room. Internal comfort features include the innovative ECCO Comfort " +
                    "Fibre System™ for all-day freshness, while the specially designed platform is created using a " +
                    "specially-designed cemented leather sole that's incredibly flexible and sure footed for all-day wearability."
                },

                new Product
                {
                    Name = "Black Ecco Shoes",
                    Section = 0,
                    Category = 0,
                    Gender = 0,
                    Price = 149.99m,
                    Image = "~/Resources/BlackMensShoes.jpg",
                    Description = "A modern, comfortable shoe with clean upper styling, Uppers made of full grain leather, " +
                    "Textile lining, Glued-in leather footbed with ECCO Comfort Fibre System™(ECFS), Direct injected, one " +
                    "component PU outsole, Comfort shank technology, Highly breathable and moisture absorbent lining, ECFS " +
                    "increases air circulation for perfect inner climate, Light and flexible sole with a slim profile, " +
                    "Airport friendly"
                },

                new Product
                {
                    Name = "Men's Boots",
                    Section = 0,
                    Category = 0,
                    Gender = 0,
                    Price = 199.99m,
                    Image = "~/Resources/MensBoots.jpg",
                    Description = "A modern chukka boot with a trend inspired look in classic, yet rugged oily leather " +
                    "types and a classic leather welt Hydromax treated leather for water-resistance ensuring warm, dry feet " +
                    "all day Removable leather-covered inlay sole with ECFS™ for increased air circulation for a perfect " +
                    "inner climate Direct-injected, PU outsole. Light and durable sole with and modern design"
                },

                new Product
                {
                    Name = "Jack Jones Jeans",
                    Section = 0,
                    Category = (ProductCategory)1,
                    Gender = 0,
                    Price = 49.99m,
                    Image = "~/Resources/MensJeans.jpg",
                    Description = "Founded in 1989, Jack & Jones is a Danish brand that offers cool, relaxed designs " +
                    "that express a strong visual style through their diffusion lines, Jack & Jones intelligence and " +
                    "Jack & Jones vintage."
                },

                new Product
                {
                    Name = "Chinos",
                    Section = 0,
                    Category = (ProductCategory)1,
                    Gender = 0,
                    Price = 29.99m,
                    Image = "~/Resources/Chinos.jpg",
                    Description = "Get a classic look with these Mens Kangol Chino Trousers which come in a straight leg " +
                    "design, offer wonderful comfort and freedom of movement. These mens chino's have a button fly and " +
                    "fastening and there are five pockets so you can carry all your belongings with ease."
                },

                new Product
                {
                    Name = "Navy Trousers",
                    Section = 0,
                    Category = (ProductCategory)1,
                    Gender = 0,
                    Price = 69.99m,
                    Image = "~/Resources/MensTrousers.jpg",
                    Description = "These Mens Bruhl Montana Trousers have been crafted with button fastening and a zip " +
                    "fly for a secure fit, whilst the Stretch Plus waistband ensures you can spend your day in complete " +
                    "comfort and the four pockets allow you to carry everything you need with complete ease."
                },

                new Product
                {
                    Name = "Jack Jones Knit Jumper",
                    Section = 0,
                    Category = (ProductCategory)2,
                    Gender = 0,
                    Price = 49.99m,
                    Image = "~/Resources/MensKnitJumper.jpg",
                    Description = "Founded in 1989, Jack & Jones is a Danish brand that offers cool, relaxed designs " +
                    "that express a strong visual style through their diffusion lines, Jack & Jones intelligence and " +
                    "Jack & Jones vintage."
                },

                new Product
                {
                    Name = "Grey Jumper",
                    Section = 0,
                    Category = (ProductCategory)2,
                    Gender = 0,
                    Price = 29.99m,
                    Image = "~/Resources/MensJumper.jpg",
                    Description = "Enjoy a comfortable and casual wear in this wardrobe staple Pierre Cardin V Neck " +
                    "Knit Jumper Men's, crafted with a v neck, long sleeves with ribbed cuffs, a ribbed hem and complete " +
                    "with Pierre Cardin embroidered branding to the left chest. "
                },

                new Product
                {
                    Name = "Grey Nike Hoodie",
                    Section = 0,
                    Category = (ProductCategory)2,
                    Gender = 0,
                    Price = 79.99m,
                    Image = "~/Resources/MensHoodie.jpg",
                    Description = "Keep your look stylish with this Nike Graphic Full Zip Hoodie. Crafted with a drawstring " +
                    "adjustable hood and full zip fastening, this jacket features long sleeves, ribbed trims and 2 open " +
                    "pockets. It is designed with a printed chest panel, soft fleece lining, a printed logo and is complete " +
                    "with Nike Swoosh branding."
                },

                new Product
                {
                    Name = "Rain Jacket",
                    Section = 0,
                    Category = (ProductCategory)3,
                    Gender = 0,
                    Price = 79.99m,
                    Image = "~/Resources/MensRainJacket.jpg",
                    Description = "The Millet Tronad 2L Jacket is constructed with Dryedge technology which offers you a " +
                    "fabric that is waterproof and windproof as well as being completely breathable to ensure you are kept " +
                    "ventilated whilst your body heat is regulated as you wear."
                },

                new Product
                {
                    Name = "Camoflage Jacket",
                    Section = 0,
                    Category = (ProductCategory)3,
                    Gender = 0,
                    Price = 139.99m,
                    Image = "~/Resources/MensWinterJacket.jpg",
                    Description = "The jacket includes fully taped seams and welded construction details for a clean look, " +
                    "Dryride Durashell dual layer fabric that has a water repellent coating plus a waterproof and breathable " +
                    "membrane and Thermolite insulation for superior warmth."
                },

                new Product
                {
                    Name = "Black Coat",
                    Section = 0,
                    Category = (ProductCategory)3,
                    Gender = 0,
                    Price = 189.99m,
                    Image = "~/Resources/MensCoat.jpg",
                    Description = "Farah Vintage double breasted wool peacoat jacket with removable gold pin badge detailing. " +
                    "Logo buttons. 82 % wool 16 % polyester 1 % viscose 1 % acrylic. 56 % polyester 44 % viscose lining. " +
                    "Double breasted. Button fastening. Two front pockets. Single back vent. Straight hem."
                },

                new Product
                {
                    Name = "Black Dress",
                    Section = (ProductSection)1,
                    Category = (ProductCategory)4,
                    Gender = (Gender)1,
                    Price = 129.99m,
                    Image = "~/Resources/BlackDress.jpg",
                    Description = "Prom queens, make sure you own the night in Love Triangle's spotlight-stealing separates " +
                    "and maxi dresses. Fall for floor-sweeping layers of lace, plunging necklines and bodycon dresses to " +
                    "switch up your look, from polished party to after party."
                },

                new Product
                {
                    Name = "Floral Dress",
                    Section = (ProductSection)1,
                    Category = (ProductCategory)4,
                    Gender = (Gender)1,
                    Price = 89.99m,
                    Image = "~/Resources/FloralDress.jpg",
                    Description = "Translating its international travels into fresh new styles with a fun and wearable edge, " +
                    "boohoo perfects your party prep. Ripped-up denim and bandage bodycon dresses team up with a staple range " +
                    "of everyday basics to refresh your wardrobe, whatever the occasion."
                },

                new Product
                {
                    Name = "Red Dress",
                    Section = (ProductSection)1,
                    Category = (ProductCategory)4,
                    Gender = (Gender)1,
                    Price = 149.99m,
                    Image = "~/Resources/RedDress.jpg",
                    Description = "Score a wardrobe win no matter the dress code with our ASOS Collection. From polished " +
                    "prom to the after party, our London-based design team scour the globe to nail your new-season " +
                    "fashion goals with need-right-now dresses, outerwear, shoes and denim in the coolest shapes and fits."
                },

                new Product
                {
                    Name = "Blue Denim Shirt",
                    Section = 0,
                    Category = (ProductCategory)5,
                    Gender = 0,
                    Price = 39.99m,
                    Image = "~/Resources/DenimShirt.jpg",
                    Description = "This Denim Shirt by G Star features a slim fit design with a with a rounded hem and " +
                    "a point collar as well as a back darts and a soft feel for great wearing."
                },

                new Product
                {
                    Name = "Check Shirt",
                    Section = 0,
                    Category = (ProductCategory)5,
                    Gender = 0,
                    Price = 29.99m,
                    Image = "~/Resources/CheckShirt.jpg",
                    Description = "The Firetrap Blackseal Shadow Check Shirt provides a stylish wear with a full button " +
                    "fastening, long sleeves with button cuffs, a fold over collar, two button fastening chest pockets " +
                    "and an all over check print, completed with Firetrap Blackseal branding."
                },

                new Product
                {
                    Name = "White Moschino Shirt",
                    Section = 0,
                    Category = (ProductCategory)5,
                    Gender = 0,
                    Price = 59.99m,
                    Image = "~/Resources/WhiteShirt.jpg",
                    Description = "Add to your professional attire with this Moschino long sleeved shirt. Featuring a " +
                    "central button closure, a button down collar and contrasting heart detailing embroidered to the front."
                },

                new Product
                {
                    Name = "Black Turtle Neck Top",
                    Section = (ProductSection)1,
                    Category = (ProductCategory)6,
                    Gender = (Gender)1,
                    Price = 29.99m,
                    Image = "~/Resources/TurtleNeckTop.jpg",
                    Description = "Inspired by beaches, blue skies and sunshine, Southern California label Hollister " +
                    "champions an endless summer. Never taking itself too seriously, its laid-back style is infused with " +
                    "surf and skate culture, making every T-shirt, maxi dress and skater skirt effortlessly cool."
                },

                new Product
                {
                    Name = "Black Mesh Top",
                    Section = (ProductSection)1,
                    Category = (ProductCategory)6,
                    Gender = (Gender)1,
                    Price = 19.99m,
                    Image = "~/Resources/MeshTop.jpg",
                    Description = "From polished prom to the after party, our London-based design team scour the globe to " +
                    "nail your new-season fashion goals with need-right-now dresses, outerwear, shoes and denim in the " +
                    "coolest shapes and fits."
                },

                new Product
                {
                    Name = "White Frilly Top",
                    Section = (ProductSection)1,
                    Category = (ProductCategory)6,
                    Gender = (Gender)1,
                    Price = 49.99m,
                    Image = "~/Resources/WhiteTop.jpg",
                    Description = "Glamorous Tall brings us the same fashion-led pieces as their mainline collection – " +
                    "day-to-night swing dresses, printed maxis and kimonos - but this time it’s perfectly proportioned " +
                    "to fit those 5’9”/1.75m and above."
                },

                new Product
                {
                    Name = "Black High Heels",
                    Section = (ProductSection)1,
                    Category = 0,
                    Gender = (Gender)1,
                    Price = 89.99m,
                    Image = "~/Resources/HighHeels.jpg",
                    Description = "From polished prom to the after party, our London-based design team scour the globe " +
                    "to nail your new-season fashion goals with need-right-now dresses, outerwear, shoes and denim in " +
                    "the coolest shapes and fits."
                },

                new Product
                {
                    Name = "Black Flats",
                    Section = (ProductSection)1,
                    Category = 0,
                    Gender = (Gender)1,
                    Price = 39.99m,
                    Image = "~/Resources/Flats.jpg",
                    Description = "Brit high-street favourites Faith channel a love of fast fashion across their " +
                    "trend-led collections of shoes and accessories. Chic Parisian ballet pumps and studded flat sandals " +
                    "team up with Western ankle boots, skyscraper heels and platform court shoes. "
                },

                new Product
                {
                    Name = "Silver Knee-High Boots",
                    Section = (ProductSection)1,
                    Category = 0,
                    Gender = (Gender)1,
                    Price = 129.99m,
                    Image = "~/Resources/WomensBoots.jpg",
                    Description = "Score a wardrobe win no matter the dress code with our ASOS Collection. From polished " +
                    "prom to the after party, our London-based design team scour the globe to nail your new-season fashion " +
                    "goals with need-right-now dresses, outerwear, shoes and denim in the coolest shapes and fits."
                },

                new Product
                {
                    Name = "Denim Jeans",
                    Section = (ProductSection)1,
                    Category = (ProductCategory)1,
                    Gender = (Gender)1,
                    Price = 79.99m,
                    Image = "~/Resources/WomensJeans.jpg",
                    Description = "Score a wardrobe win no matter the dress code with our ASOS Collection. From polished " +
                    "prom to the after party, our London-based design team scour the globe to nail your new-season fashion " +
                    "goals with need-right-now dresses, outerwear, shoes and denim in the coolest shapes and fits."
                },

                new Product
                {
                    Name = "Denim Shorts",
                    Section = (ProductSection)1,
                    Category = (ProductCategory)1,
                    Gender = (Gender)1,
                    Price = 39.99m,
                    Image = "~/Resources/DenimShorts.jpg",
                    Description = "River Island takes you from the party to the after party with its fashion-forward " +
                    "styles. Look out for its standout party dresses, feminine details, statement jackets and cool denim " +
                    "including skinny-cut jeans and cute denim shorts, which sit alongside its directional footwear and " +
                    "swimwear ranges."
                },

                new Product
                {
                    Name = "Black Slim Leg Trousers",
                    Section = (ProductSection)1,
                    Category = (ProductCategory)1,
                    Gender = (Gender)1,
                    Price = 59.99m,
                    Image = "~/Resources/WomensTrousers.jpg",
                    Description = "Transforming the coolest looks straight from the catwalk into wardrobe staples, " +
                    "New Look joins the ASOS round up of great British high street brands. Get it or regret it with " +
                    "its weekly drops of essential coats, statement partywear and sleek boots, from ankle to " +
                    "over-the-knee styles."
                },

                new Product
                {
                    Name = "Grey Suede Shoes",
                    Section = (ProductSection)2,
                    Category = 0,
                    Gender = 0,
                    Price = 119.99m,
                    SalePrice = 79.99m,
                    Image = "~/Resources/MensShoeSale.jpg",
                    Description = "ASOS menswear shuts down the new season with the latest trends and the coolest " +
                    "products, designed in London and sold across the world."
                },

                new Product
                {
                    Name = "Heeled Ankle Boot",
                    Section = (ProductSection)2,
                    Category = 0,
                    Gender = (Gender)1,
                    Price = 79.99m,
                    SalePrice = 49.99m,
                    Image = "~/Resources/WomensShoeSale.jpg",
                    Description = "Translating its international travels into fresh new styles with a fun and wearable " +
                    "edge, boohoo perfects your party prep."
                },

                new Product
                {
                    Name = "Jack Jones Trousers",
                    Section = (ProductSection)2,
                    Category = (ProductCategory)1,
                    Gender = 0,
                    Price = 89.99m,
                    SalePrice = 59.99m,
                    Image = "~/Resources/MensTrouserSale.jpg",
                    Description = "Founded in 1989, Jack & Jones is a Danish brand that offers cool, relaxed " +
                    "designs that express a strong visual style through their diffusion lines, Jack & Jones " +
                    "intelligence and Jack & Jones vintage."
                },

                new Product
                {
                    Name = "Black Women's Trousers",
                    Section = (ProductSection)2,
                    Category = (ProductCategory)1,
                    Gender = (Gender)1,
                    Price = 99.99m,
                    SalePrice = 69.99m,
                    Image = "~/Resources/WomensTrouserSale.jpg",
                    Description = "Tripp NYC encapsulates the underground ethos of urban living. Influenced by " +
                    "music, look to collections inspired by urban subcultures over fleeting fashion trends. Skinny " +
                    "jeans emblazoned with tartan and snake prints and cool slouchy knits lead the way in Tripp NYC's " +
                    "uber cool collection."
                },

                new Product
                {
                    Name = "Men's Cardigan",
                    Section = (ProductSection)2,
                    Category = (ProductCategory)2,
                    Gender = 0,
                    Price = 79.99m,
                    SalePrice = 49.99m,
                    Image = "~/Resources/Cardigan.jpg",
                    Description = "Still continuing to stand at the forefront of men's fashion; Selected Homme " +
                    "specialises in raw and simple designs that are never obviously trend-driven, but always edgy, " +
                    "elegant and masculine with focus on attention to detail."
                },

                new Product
                {
                    Name = "Men's Duffle Coat",
                    Section = (ProductSection)2,
                    Category = (ProductCategory)3,
                    Gender = 0,
                    Price = 129.99m,
                    SalePrice = 89.99m,
                    Image = "~/Resources/DuffleCoat.jpg",
                    Description = "Bellfield offers well-constructed modern menswear that has a sense of fun and " +
                    "adventure. Unexpected details feature on cut and sew t-shirts, shirts, trousers and shorts that " +
                    "are carefully thought out by the London based creative team and live up to fresh and honest " +
                    "approach to design that is the Bellfield style and philosophy."
                },

                new Product
                {
                    Name = "Star Print Dress",
                    Section = (ProductSection)2,
                    Category = (ProductCategory)4,
                    Gender = (Gender)1,
                    Price = 109.99m,
                    SalePrice = 79.99m,
                    Image = "~/Resources/DressSale.jpg",
                    Description = "An eclectic mix of vintage influences and contemporary partywear are at the heart of " +
                    "Manchester based label Glamorous, where individual style is the key."
                },

                new Product
                {
                    Name = "Blue Shirt",
                    Section = (ProductSection)2,
                    Category = (ProductCategory)5,
                    Gender = 0,
                    Price = 29.99m,
                    SalePrice = 19.99m,
                    Image = "~/Resources/BlueShirt.jpg",
                    Description = "Renowned for their classic canvas slacks and sharply cut tailoring, Farah " +
                    "retains its heritage across a collection of slim fitting polo shirts and checked flannel shirts."
                },

                new Product
                {
                    Name = "Red Crop Top",
                    Section = (ProductSection)2,
                    Category = (ProductCategory)6,
                    Gender = (Gender)1,
                    Price = 49.99m,
                    SalePrice = 39.99m,
                    Image = "~/Resources/CropTop.jpg",
                    Description = "Easy-wear pieces with boho prints and super-soft fabrics make up Kiss The Sky’s " +
                    "festival-ready collection. Channel its laid-back California style in swing dresses, maxis and " +
                    "crochet-trim playsuits."
                }
                );
        }
    }
}

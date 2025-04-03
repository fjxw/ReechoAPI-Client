import { Vynil } from "@/components/vynil-card.tsx";

export const CardList = ({ data } : any) => {
    return (
        <div className="container mx-auto px-20 my-5 grid grid-cols-1 sm:grid-cols-2 md:grid-cols-3 lg:grid-cols-4 gap-6 justify-items-center">
            {data.map((product : any) => (
                <Vynil key={product.id} {...product} />
            ))}
        </div>
    );
};

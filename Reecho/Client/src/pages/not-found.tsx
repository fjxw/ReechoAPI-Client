import {Label} from "@/components/ui/label.tsx";

export const NotFound = () => {
    return (
        <div className="flex flex-col justify-center items-center h-full">
            <Label className="text-8xl font-extrabold">404</Label>
            <Label className="text-4xl opacity-35">Страница не найдена</Label>
        </div>
    )
}
import { Button } from "@/components/ui/button"
import {
    Card,
    CardContent,
    CardFooter,
    CardHeader,
} from "@/components/ui/card"
import {Label} from "@/components/ui/label.tsx";


export const Vynil = (props : any) => {
    const url = "http://reecho_webapi:5000"
    return (
        <Card className="w-[320px] flex flex-col">
            <CardHeader>
                <img className="h-48 w-96 rounded-2xl object-cover border-2" src={`${url}/${props.image}`} />
            </CardHeader>
            <CardContent>
                <div className="flex flex-col gap-2">
                    <div>
                        <Label className="text-[20px]">{props.title}</Label>
                        <Label className="text-[16px] opacity-50">{props.artist}</Label>
                    </div>
                    <Label className="text-2xl font-bold">{`${props.price} руб.`}</Label>
                </div>
            </CardContent>
            <CardFooter className="mt-auto flex justify-end gap-2">
                <Button variant="outline">Добавить в корзину</Button>
                <Button>Купить</Button>
            </CardFooter>
        </Card>
    )
}